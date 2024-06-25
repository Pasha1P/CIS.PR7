using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПР7._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int rand, rand2;
        Random rnd = new Random();
        string[] textString = new string[] {
        "Лето выдалось просто сумасшедшим! Я всё расскажу, только не бейте! Начал с того, что случайно попал на фестиваль воздухоплавания. Представьте, я летел на воздушном шаре над полями! Потом отправился в поход с друзьями, но," +
            " честно говоря, немного заблудился. Хорошо, что мы с собой взяли много еды и воды. Зато теперь я знаю, как ориентироваться по звездам! А в конце лета… ну, это история уже для другой беседы.",
        "Ну, значит, так. Жил-был я в этом году… нет, не в сказке, а в обычном городе. Но лето у меня было не простое. Сначала я пошёл на курсы по программированию. Тяжело, но интересно! Потом мы с родителями поехали на море. Я даже" +
            " научился плавать! А самое главное, я познакомился с потрясающими ребятами, с которыми теперь постоянно общаюсь. В общем, было весело и насыщенно!",
        "Как я провел лето? Это конфиденциальная информация. Обращайтесь к моему адвокату! Шучу, конечно. Просто… ну, скажем так, это было лето, полное неожиданных поворотов. У меня было много приключений, некоторые из которых я даже" +
            " не могу рассказать. Но могу сказать, что это был незабываемый опыт, который я никогда не забуду."};
        string[] phrase = new string[] {
        "Я всё расскажу, только не бейте!",
        "Ну, значит, так. Жил-был я … ",
        "Это конфиденциальная информация. Обращайтесь к моему адвокату!"};
        public MainWindow()
        {
            InitializeComponent();
            Width = 370;
            Height = 100;
            Speac.HorizontalAlignment = HorizontalAlignment.Center;
            Speac.VerticalAlignment = VerticalAlignment.Stretch;
            Speac.Margin = new Thickness(0, 21, 0, 196);
        }

        private void Speac_Click(object sender, RoutedEventArgs e)
        {
            Height = 285;
            Speac.VerticalAlignment = VerticalAlignment.Top;
            Speac.Margin = new Thickness(0, 213, 0, 0);
            Text.Height = 198;
            //Speac.Height = Height;
            Text.Visibility = Visibility.Visible;
            while (rand == rand2)
                rand = rnd.Next(textString.Length);
            if (rand == 2)
            {
                Text.Height = 164;
                Height = 248;
                Speac.VerticalAlignment = VerticalAlignment.Top;
                Speac.Margin = new Thickness(0, 179, 0, 0);
            }
            Text.Text = textString[rand];
            Speac.Content = "Рассказать про другое лето";
            Speac.Width = 330;
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = Width;
            double windowHeight = Height;
            Left = (screenWidth / 2) - (windowWidth / 2);
            Top = (screenHeight / 2) - (windowHeight / 2);
            MessageBox.Show($"В этом текте использована данная фраза:\n'{phrase[rand]}'", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            rand2 = rand;
        }
    }
}
