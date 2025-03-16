using ToolsForOffice.Shared;
using System.Runtime.InteropServices;
using ToolsForOffice.Notification.Classes;
using ToolsForOffice.Notification.Properties;

namespace ToolsForOffice.Notification
{
    public partial class NotificationForm : Form
    {
        #region Graphics

        Graphics? Canvas;
        Random? rnd;

        Effect[]? Effects;

        readonly int CloudCount = 50;
        readonly int SnowflakeCount = 300;
        readonly int GreenLeafCount = 100;

        bool isCloud;
        bool isSummer;
        bool isSpring;
        bool isFall;
        bool isSnow;

        readonly Bitmap cloud = new(Resources.SingleCloud64);
        readonly Bitmap snow = new(Resources.SingleSnowflake16);
        readonly Bitmap spring = new(Resources.SingleSpringLeaf16);
        readonly Bitmap summer = new(Resources.SingleGreenLeaf16);
        readonly Bitmap fall = new(Resources.SingleAutumnLeaf16);

        #endregion

        #region Properties

        private NotificationAction _action;
        private int _interval;
        private int positionX;
        private int positionY;
        protected override bool ShowWithoutActivation => true;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        #endregion

        private void LoadTheme()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-ToolsTheme.bin");
            SelectedTheme selectedTheme = SelectedTheme.Load(filePath);

            switch (selectedTheme.CurrentTheme)
            {
                case Theme.Cloud:
                    StartCloud();
                    isCloud = true;
                    MessageLabel.ForeColor = Color.White;
                    ClickMessage.ForeColor = Color.White;
                    break;
                case Theme.Summer:
                    StartSummer();
                    isSummer = true;
                    MessageLabel.ForeColor = Color.White;
                    ClickMessage.ForeColor = Color.White;
                    break;
                case Theme.Spring:
                    StartSpring();
                    isSpring = true;
                    MessageLabel.ForeColor = Color.Black;
                    ClickMessage.ForeColor = Color.Black;
                    LogoImage.Image = Resources.Camera48px_dark;
                    CloseButton.Image = Resources.Close48px_dark;
                    break;
                case Theme.Fall:
                    StartFall();
                    isFall = true;
                    MessageLabel.ForeColor = Color.Black;
                    ClickMessage.ForeColor = Color.Black;
                    LogoImage.Image = Resources.Camera48px_dark;
                    CloseButton.Image = Resources.Close48px_dark;
                    break;
                case Theme.Snow:
                    StartSnow();
                    isSnow = true;
                    MessageLabel.ForeColor = Color.Black;
                    ClickMessage.ForeColor = Color.Black;
                    LogoImage.Image = Resources.Camera48px_dark;
                    CloseButton.Image = Resources.Close48px_dark;
                    break;
                case Theme.Default:
                    MessageLabel.ForeColor = Color.White;
                    ClickMessage.ForeColor = Color.White;
                    BackColor = Color.FromArgb(48,48,48);
                    break;
            }
        }

        private static string GetFolder()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyFolder.bin");
            string folderPath;
            using (var binaryReader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                folderPath = binaryReader.ReadString();
            }
            return folderPath + "/";
        }

        public NotificationForm()
        {
            InitializeComponent();
            MainPictureBox.Invalidate();
            LogoImage.Parent = MainPictureBox;
            MessageLabel.Parent = MainPictureBox;
            CloseButton.Parent = MainPictureBox;
            ClickMessage.Parent = MainPictureBox;
            ClickMessage.BringToFront();
            LoadTheme();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            return directory.GetFiles()
                .Where(f => (f.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden && (f.Attributes & FileAttributes.System) != FileAttributes.System && f.Extension == ".jpg")
                .OrderByDescending(f => f.LastWriteTime)
                .FirstOrDefault()!;
        }

        private async void NotificationForm_Click(object sender, EventArgs e)
        {
            MainTimer.Interval = 1;
            _action = NotificationAction.Close;
            FileInfo newestFile = await Task.Run(() => GetNewestFile(new DirectoryInfo(GetFolder())));
            if (!File.Exists(newestFile.FullName))
            {
                return;
            }
            string argument = "/open, \"" + Path.Combine(newestFile.DirectoryName!, newestFile.Name) + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            switch (_action)
            {
                case NotificationAction.Start:
                    MainTimer.Interval = 1;
                    Opacity += 0.1;

                    if (positionX < Location.X) Left--;
                    else if (Opacity == 1.0) _action = NotificationAction.Wait;

                    break;
                case NotificationAction.Wait:
                    MainTimer.Interval = _interval;
                    _action = NotificationAction.Close;
                    break;
                case NotificationAction.Close:
                    MainTimer.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (Opacity == 0.0) Close();
                    break;
            }
        }

        //Keep window on top always
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 8;  // Turn on WS_EX_TOPMOST
                return cp;
            }
        }

        internal void ShowNotification(string message, NotificationType notificationType, int interval, Image image = null!, Color color = default)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;

            for (int i = 1; i < 10; i++)
            {
                var formName = "notification" + i;
                var form = (NotificationForm)Application.OpenForms[formName]!;

                if (form == null)
                {
                    Name = formName;
                    positionX = Screen.PrimaryScreen!.WorkingArea.Width - Width + 15;
                    positionY = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(positionX, positionY);
                    break;
                }
            }

            positionX = Screen.PrimaryScreen!.WorkingArea.Width - Width - 5;

            MessageLabel.Text = message;
            _interval = interval;
            _action = NotificationAction.Start;
            MainTimer.Interval = 1;
            MainTimer.Start();

            Show();
        }

        #region All Animations
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            MainPictureBox.Invalidate();
        }
        private void MakeCloud()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble();

            for (int i = 0; i < CloudCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed, rnd!.Next(16, 64), 1, cloud);
            }
        }
        private void MakeSnow()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 16), 1, snow);
            }
        }
        private void MakeSpring()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 32), 1, spring);
            }
        }
        private void MakeSummer()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < GreenLeafCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 16), 1, summer);
            }
        }
        private void MakeAutumn()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed / 1.5f, rnd!.Next(8, 16), 1, fall);
            }
        }
        private void StartSnow()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeSnow();
        }
        private void StartSpring()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeSpring();
        }
        private void StartSummer()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[GreenLeafCount];
            MakeSummer();
        }
        private void StartFall()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeAutumn();
        }
        private void StartCloud()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[CloudCount];
            MakeCloud();
        }
        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (isCloud)
            {
                Canvas?.Clear(Color.SteelBlue);
            }
            else if (isSummer)
            {
                Canvas?.Clear(Color.Green);
            }
            else if (isSpring)
            {
                Canvas?.Clear(Color.Pink);
            }
            else if (isFall)
            {
                Canvas?.Clear(Color.Orange);
            }
            else if (isSnow)
            {
                Canvas?.Clear(Color.White);
            }
            else
            {
                // Default color
                Canvas?.Clear(Color.White);
            }

            if (isSnow)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -25;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isCloud)
            {
                for (int i = 0; i < CloudCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;

                    if (Effects[i].X > 700)
                    {
                        Effects[i].X = -25;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].Y > 580 & Effects[i].Y < -5)
                    {
                        Effects[i].Y = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].X += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isFall)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.01f;
                    Effects[i].X += (float)Math.Sin(Effects[i].Time) * 2;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0.1f;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isSpring)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.2f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isSummer)
            {
                for (int i = 0; i < GreenLeafCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.2f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -25;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
        }

        #endregion

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}