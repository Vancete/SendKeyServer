using System;
using System.Net;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SendKeyServer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static Listener listener;
        public int port = 7537;
        private static ListBox lb;

        public MainWindow()
        {
            InitializeComponent();
            lb = this.listBox;

            System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
            ni.Icon = new System.Drawing.Icon(Application.GetResourceStream(new Uri("pack://application:,,,/res/sks.ico")).Stream);
            ni.Visible = true;
            ni.DoubleClick +=
                delegate (object sender, EventArgs args)
                {
                    this.Show();
                    this.WindowState = WindowState.Normal;
                };

            listener = new Listener(port);

            status.Content = "Listening on port " + port;
            AddItem("Started listening on " + port);

        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
                this.Hide();

            base.OnStateChanged(e);
        }

        public static void AddItem(string t)
        {
            App.Current.Dispatcher.Invoke(delegate {
                DateTime dt = DateTime.Now;
                ListBoxItem item = new ListBoxItem();
                item.Content = "[" + dt.ToString("HH:mm:ss") + "] " + t;
                lb.Items.Insert(0, item);
            });
        }
    }
}
