using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Ninject;
using Ninject.Modules;


namespace FlatGUI
{
    public partial class MainForm : Form
    {
        private Color closeColor = Color.Tomato;
        private Color activColor = SystemColors.GradientActiveCaption;
        private Color standartColor = SystemColors.ControlLight;

        private string[] btnFilms_text = { "Фильмы", "F" };
        private string[] btnSerials_text = { "Сериалы", "S" };

        public MainForm()
        {
            InitializeComponent();
        }

        #region Закрытие, сворачивание, разворачивание, восстановление, перемещение приложения

        #region Перемещение окна по экрану 
        // для перетаскивания приложения по экрану

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PanelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Закрытие приложения 
        // закрыть приложение
        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Разворачивание приложения на весь экран
        //развернуть приложение на весь экран
        private void MaximizeApplication_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestore.Visible = true;
            iconMaximize.Visible = false;
        }
        #endregion

        #region Восстановление приложения к начальному размеру
        // восстановить приложение к начальному размеру
        private void RestoreApplication_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconMaximize.Visible = true;
            iconRestore.Visible = false;
        }
        #endregion

        #region Сворачивание приложения в трэй
        // свернуть приложение
        private void MinimizeApplication_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            SystemTrayIcon.Visible = true;
            Hide();
        }
        #endregion

        #region Разворачивание приложения из трэя
        private void SystemTrayIcon_DoubleClick(object sender, EventArgs e)
        {
            SystemTrayIcon.Visible = false;
            Show();
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        #endregion

        #region Смена цвета кнопки при снятии/наведении курсора на нее

        // при наведении на кнопку менять цвет
        private void Icon_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb.Name == "iconClose")
            {
                pb.BackColor = closeColor;
            }
            else
            {
                pb.BackColor = activColor;
            }
        }

        // при снятии курсора менять цвет обратно
        private void Icon_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = standartColor;
        }

        #endregion

        // свернуть/развернуть меню
        private void IconMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 200)
            {
                panelMenu.Width = 80;
                lineMenu.Width = 70;
                lineMenu.Location = new Point(5, lineMenu.Location.Y); // меняем позицию подчеркивающей линии

                btnFilms.Text = btnFilms_text[1];
                btnSerials.Text = btnSerials_text[1];
            }
            else
            {
                panelMenu.Width = 200;
                lineMenu.Width = 180;
                lineMenu.Location = new Point(10, lineMenu.Location.Y); // меняем позицию подчеркивающей линии

                btnFilms.Text = btnFilms_text[0];
                btnSerials.Text = btnSerials_text[0];
            }
        }

        // кнопка "Фильмы"
        private void BtnFilms_Click(object sender, EventArgs e)
        {
            ChangeHeader(sender as Button); // меняем текст в заголовке

            //TODO: УДАЛИТЬ
            /* 
                        List<FilmDTO> films = new List<FilmDTO>();
                        Class1 class1 = new Class1();
                        films = class1.AddFilm();

                        foreach (var f in films)
                        {
                            TextBox tb = new TextBox();

                            int Y = 10 + count * 22;
                            tb.Size = new Size(740, 20);
                            tb.Location = new Point(10, Y);

                            tb.Text = f.Id + " | " + f.Name + " | " + f.Description + " | " + f.Country + " | " + f.Genre + " | ";

                            panelContent.Controls.Add(tb);
                            count++;
                        }
            */

            #region переписать
            //TODO: Переписать + добавить асинхронную загрузку
            NinjectModule filmModule = new Util.FilmModule();
            NinjectModule serviceModule = new BLogicLayer.Infrastructure.ServiceModule("TestSQL");
            var kernel = new StandardKernel(filmModule, serviceModule);
            var test = kernel.Get<BLogicLayer.Services.FilmService>();
            var filmssss = test.GetFilms();

            var Xx = 0;
            var Yy = 0;
            var countX = 0;
            var countY = 0;

            foreach (var f in filmssss)
            {
                Xx = 160 * countX + 10 * (countX + 1);
                Yy = 240 * countY + 10 * (countY + 1);
                UserControl1 uc = new UserControl1();

                uc.Location = new Point(Xx, Yy);
                uc.linkLabel1.Text = f.Name;
                countX++;
                if (countX == 4)
                {
                    countY++;
                    countX = 0;
                }
                panelContent.Controls.Add(uc);
            }
            #endregion
        }

        // кнопка "Сериалы"
        private void BtnSerials_Click(object sender, EventArgs e)
        {
            ChangeHeader(sender as Button); // меняем текст в заголовке
        }

        // Функция для замены заголовка
        private void ChangeHeader(Button but)
        {
            labelHeader.Text = but.Text;
        }

        /*
        #region тестовая кнопка
        //TODO: Удалить, когда не нужна будет
        Button btn;
        int count = 2;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btn = new Button();
            int Y = 60 + count * 56;
            btn.Size = new Size(180, 50);
            btn.Location = new Point(10, Y);
            btn.Name = "btn" + count.ToString();
            btn.Text = count.ToString();

            panelMenu.Controls.Add(btn);
            count++;
        }
        #endregion
        */
    }
}
