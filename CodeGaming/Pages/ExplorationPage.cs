using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGaming.Pages
{
    public partial class ExplorationPage : Form
    {
        public ExplorationPage()
        {
            InitializeComponent();
        }

        private void btnShowJavelin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://imgur.com/a/hzvTzX2");
            ExplorationPopup popup = new ExplorationPopup();
            popup.lblHeader.Text = "Javelin";
            popup.lblText.Text = "1. Совершите квантовый прыжок на Daymar\n2. Далее квантовый прыжок на OM 3\n3. В районе 45 - 50° находим горы(см.скриншот)\n4. Летим ровно на точку указанную на скриншоте\n5. Пролетаем гору на третьем скриншоте и сразу поворачиваем налево\n6. Внимательно смотрим на поверхность - обломки должно быть в зоне видимости\n\nКоординаты(OM) - 577,2:459,0:204,8:708,6:577,2:660,0";
            popup.txtImgur.Text = "Скриншоты: https://imgur.com/a/hzvTzX2";
            popup.Show();
        }

        private void btnShowRiver_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.youtube.com/watch?v=2_NFGJ3mXOc");
            ExplorationPopup popup = new ExplorationPopup();
            popup.lblHeader.Text = "Река на Microtech";
            popup.lblText.Text = "1. Совершите квантовый прыжок до New Babbage\n2. Развернитесь по напаравлению 207°\n3. Найдите и совершите квантовый прыжок до точки интереса \"MT DataCenter E2Q-NSG-Y\"\n4. Остановите квантовый прыжок примерно в 900 км от точки назначения\n5. Продолжайте полет на зеленый биом прямо по курсу, и вскоре увидите реку.\n\nКоординаты(OM) - 1370:2066:1369:2066:8620:2324";
            popup.txtImgur.Text = "Видео: https://www.youtube.com/watch?v=2_NFGJ3mXOc";
            popup.Show();
        }

        private void btnShowCanyon_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.youtube.com/watch?v=y751Kvg1vN4");
            ExplorationPopup popup = new ExplorationPopup();
            popup.lblHeader.Text = "Каньон Hurston";
            popup.lblText.Text = "1. Совершите квантовый прыжок до Hurston\n2. Затем прыгните на OM 1\n3. Задайте курс прямо по направлению к точке Hurston(центр планеты)\n4. Приближайтесь к поверхности\n5. На высоте 2000 м разверните корабль на курс 35°\n6. Продолжайте движение пока не увидите каньон\n\nКоординаты(OM) - 436,2:2,437:1,743:1,758:1,744:1,757";
            popup.txtImgur.Text = "Видео: https://www.youtube.com/watch?v=y751Kvg1vN4";
            popup.Show();
        }

        private void btnShowGrimHexHide_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://youtu.be/_9BlhmfYv40");
            ExplorationPopup popup = new ExplorationPopup();
            popup.lblHeader.Text = "Убежище на Grim HEX";
            popup.lblText.Text = "1. Приземлитесь на заброшенную площадку №3\n 2.Повернитесь в сторону космоса чтобы цифра 3 была за вашей спиной\n3. Подбегите к краю платформы и плавно спуститесь вниз\n4. Обернитесь и увидите небольшой вход в пещеру";
            popup.txtImgur.Text = "Видео: https://youtu.be/_9BlhmfYv40";
            popup.Show();
        }

        private void btnShowNewYear_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://imgur.com/a/jKDTnPT");
            ExplorationPopup popup = new ExplorationPopup();
            popup.lblHeader.Text = "Новогоднее местечко Microtech";
            popup.lblText.Text = "1. Совершите квантовый прыжок на New Babbage, Microtech\n2. Летите по направлению к Космическому Порту\n3. Развернитесь по направлению к городу и летите над мостом для поездов\n4. У основания моста со стороны города садитесь как можно ближе к проходу\n5. Высаживайтесь на планету и идите в проход\n6. Прямо перед вами будет ламповый грот";
            popup.txtImgur.Text = "Скриншоты: https://imgur.com/a/jKDTnPT";
            popup.Show();
        }
    }
}
