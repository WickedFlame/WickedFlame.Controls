using System.Windows;
using System.Windows.Input;

namespace WickedFlame.Controls.Shell
{
    public class Window : System.Windows.Window
    {
        static Window()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata(typeof(Window)));
        }

        public Window()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            CommandBindings.Add(new CommandBinding(System.Windows.SystemCommands.CloseWindowCommand, OnSystemWindowCommandExecute));
            CommandBindings.Add(new CommandBinding(System.Windows.SystemCommands.MaximizeWindowCommand, OnSystemWindowCommandExecute));
            CommandBindings.Add(new CommandBinding(System.Windows.SystemCommands.RestoreWindowCommand, OnSystemWindowCommandExecute));
            CommandBindings.Add(new CommandBinding(System.Windows.SystemCommands.MinimizeWindowCommand, OnSystemWindowCommandExecute));
        }

        /// <summary>
        /// Handle the system window commands for window minimize, maximize, restore and close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSystemWindowCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == System.Windows.SystemCommands.CloseWindowCommand)
                System.Windows.SystemCommands.CloseWindow(this);

            if (e.Command == System.Windows.SystemCommands.MaximizeWindowCommand)
                System.Windows.SystemCommands.MaximizeWindow(this);

            if (e.Command == System.Windows.SystemCommands.RestoreWindowCommand)
                System.Windows.SystemCommands.RestoreWindow(this);

            if (e.Command == System.Windows.SystemCommands.MinimizeWindowCommand)
                System.Windows.SystemCommands.MinimizeWindow(this);
        }

        #region DependencyProperties

        public bool ShowIconInHeader
        {
            get { return (bool)GetValue(ShowIconInHeaderProperty); }
            set { SetValue(ShowIconInHeaderProperty, value); }
        }

        public static readonly DependencyProperty ShowIconInHeaderProperty = DependencyProperty.Register(
            "ShowIconInHeader", 
            typeof(bool), 
            typeof(Window), 
            new PropertyMetadata(true));



        public bool ShowHeader
        {
            get { return (bool)GetValue(ShowHeaderProperty); }
            set { SetValue(ShowHeaderProperty, value); }
        }

        public static readonly DependencyProperty ShowHeaderProperty = DependencyProperty.Register(
            "ShowHeader", 
            typeof(bool), 
            typeof(Window), 
            new PropertyMetadata(true));


        public bool CanWindowMaximize
        {
            get { return (bool)GetValue(CanWindowMaximizeProperty); }
            set { SetValue(CanWindowMaximizeProperty, value); }
        }

        public static readonly DependencyProperty CanWindowMaximizeProperty = DependencyProperty.Register(
            "CanWindowMaximize", 
            typeof(bool), 
            typeof(Window), 
            new PropertyMetadata(true));




        public bool CanWindowCollapse
        {
            get { return (bool)GetValue(CanWindowCollapseProperty); }
            set { SetValue(CanWindowCollapseProperty, value); }
        }

        public static readonly DependencyProperty CanWindowCollapseProperty = DependencyProperty.Register(
            "CanWindowCollapse", 
            typeof(bool), 
            typeof(Window), 
            new PropertyMetadata(true));



        #endregion
    }
}
