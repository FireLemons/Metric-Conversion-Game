using ToMetric.BindingConversionClasses;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ToMetric.ModelClasses;

namespace ToMetric
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameModel gameModel;
        private OptionsModel optionsModel;
        private TabModel tabModel;
        private List<ConversionType> problemPool;

        public MainWindow()
        {
            InitializeComponent();

            problemPool = new List<ConversionType>();
            tabModel = new TabModel();
            optionsModel = new OptionsModel(problemPool);
            gameModel = new GameModel(problemPool);

            BindAll();
        }

        private void BindAll()
        {
            App.DataContext = tabModel;
            Options.DataContext = optionsModel;
            Game.DataContext = gameModel;
            
            TextBox userInput = GetInput(UserInput) ?? throw new NullReferenceException("Could not find text input for course gpa");

            Binding b = new Binding("UserInput")
            {
                Converter = new TextInputToDoubleText(),
                Source = gameModel,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            userInput.SetBinding(TextBox.TextProperty, b);
        }

        private void OpenOptions(object sender, RoutedEventArgs e)
        {
            tabModel.IsGame = false;
        }

        private void CloseOptions(object sender, RoutedEventArgs e)
        {
            tabModel.IsGame = true;
        }

        private void SaveOptions(object sender, System.ComponentModel.CancelEventArgs e)
        {
            optionsModel.Save();
        }

        private void Evaluate(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                gameModel.Evaluate(optionsModel.Precision);
            }
        }

        private TextBox GetInput(ContentControl placeHolderUIElement)
        {
            placeHolderUIElement.ApplyTemplate();
            return (TextBox)placeHolderUIElement.Template.FindName("Input", placeHolderUIElement);
        }
    }
}
