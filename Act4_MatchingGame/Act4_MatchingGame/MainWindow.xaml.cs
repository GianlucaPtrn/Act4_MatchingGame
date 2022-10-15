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

namespace Act4_MatchingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            affichageWpf();
        }

        public void affichageWpf()
        {
            //Définition Colonne et ligne
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            ColumnDefinition coldef4 = new ColumnDefinition();
            GrdMain.ColumnDefinitions.Add(coldef1);
            GrdMain.ColumnDefinitions.Add(coldef2);
            GrdMain.ColumnDefinitions.Add(coldef3);
            GrdMain.ColumnDefinitions.Add(coldef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            GrdMain.RowDefinitions.Add(rowDef1);
            GrdMain.RowDefinitions.Add(rowDef2);
            GrdMain.RowDefinitions.Add(rowDef3);
            GrdMain.RowDefinitions.Add(rowDef4);

            //tous les textes blocks 
            TextBlock txtB1 = new TextBlock();
            txtB1.Text = "?";
            txtB1.FontSize = 35;
            txtB1.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB1, 0);
            GrdMain.Children.Add(txtB1);

            TextBlock txtB2 = new TextBlock();
            txtB2.Text = "?";
            txtB2.FontSize = 35;
            txtB2.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB2, 1);
            GrdMain.Children.Add(txtB2);

            TextBlock txtB3 = new TextBlock();
            txtB3.Text = "?";
            txtB3.FontSize = 35;
            txtB3.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB3, 2);
            GrdMain.Children.Add(txtB3);

            TextBlock txtB4 = new TextBlock();
            txtB4.FontSize = 35;
            txtB4.Text = "?";
            txtB4.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB4, 3);
            GrdMain.Children.Add(txtB4);

            TextBlock txtB5 = new TextBlock();
            txtB5.Text = "?";
            txtB5.FontSize = 35;
            txtB5.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB5, 0);
            Grid.SetRow(txtB5, 1);
            GrdMain.Children.Add(txtB5);

            TextBlock txtB6 = new TextBlock();
            txtB6.Text = "?";
            txtB6.FontSize = 35;
            txtB6.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB6, 1);
            Grid.SetRow(txtB6, 1);
            GrdMain.Children.Add(txtB6);

            TextBlock txtB7 = new TextBlock();
            txtB7.Text = "?";
            txtB7.FontSize = 35;
            txtB7.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB7, 2);
            Grid.SetRow(txtB7, 1);
            GrdMain.Children.Add(txtB7);

            TextBlock txtB8 = new TextBlock();
            txtB8.Text = "?";
            txtB8.FontSize = 35;
            txtB8.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB8, 3);
            Grid.SetRow(txtB8, 1);
            GrdMain.Children.Add(txtB8);

            TextBlock txtB9 = new TextBlock();
            txtB9.Text = "?";
            txtB9.FontSize = 35;
            txtB9.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB9, 0);
            Grid.SetRow(txtB9, 2);
            GrdMain.Children.Add(txtB9);

            TextBlock txtB10 = new TextBlock(); 
            txtB10.Text = "?";
            txtB10.FontSize = 35;
            txtB10.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB10, 1);
            Grid.SetRow(txtB10, 2);
            GrdMain.Children.Add(txtB10);

            TextBlock txtB11 = new TextBlock();
            txtB11.Text = "?";
            txtB11.FontSize = 35;
            txtB11.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB11, 2);
            Grid.SetRow(txtB11, 2);
            GrdMain.Children.Add(txtB11);

            TextBlock txtB12 = new TextBlock();
            txtB12.Text = "?";
            txtB12.FontSize = 35;
            txtB12.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB12, 3);
            Grid.SetRow(txtB12, 2);
            GrdMain.Children.Add(txtB12);

            TextBlock txtB13 = new TextBlock();
            txtB13.Text = "?";
            txtB13.FontSize = 35;
            txtB13.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB13, 0);
            Grid.SetRow(txtB13, 3);
            GrdMain.Children.Add(txtB13);

            TextBlock txtB14 = new TextBlock();
            txtB14.Text = "?";
            txtB14.FontSize = 35;
            txtB14.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB14, 1);
            Grid.SetRow(txtB14, 3);
            GrdMain.Children.Add(txtB14);

            TextBlock txtB15 = new TextBlock();
            txtB15.Text = "?";
            txtB15.FontSize = 35;
            txtB15.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB15, 2);
            Grid.SetRow(txtB15, 3);
            GrdMain.Children.Add(txtB15);

            TextBlock txtB16 = new TextBlock();
            txtB16.Text = "?";
            txtB16.FontSize = 35;
            txtB16.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(txtB16, 3);
            Grid.SetRow(txtB16, 3);
            GrdMain.Children.Add(txtB16);

        }
    }
}
