using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WickedFlame.Controls.Shell
{
    public class SubView : ContentControl
    {
        #region Construction

        static SubView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubView), new FrameworkPropertyMetadata(typeof(SubView)));
        }

        #endregion


        

        //public void Close()
        //{
        //    RaiseViewClosedEvent();
        //}

        //#region Events

        //// Provide CLR accessors for the event
        //public event RoutedEventHandler ViewClosed
        //{
        //    add { AddHandler(ViewClosedEvent, value); }
        //    remove { RemoveHandler(ViewClosedEvent, value); }
        //}

        //// Using a RoutedEvent
        //public static readonly RoutedEvent ViewClosedEvent = EventManager.RegisterRoutedEvent(
        //    "ViewClosed",
        //    RoutingStrategy.Bubble,
        //    typeof(RoutedEventHandler),
        //    typeof(SubView));

        //internal protected void RaiseViewClosedEvent()
        //{
        //    var newEventArgs = new RoutedEventArgs(SubView.ViewClosedEvent, DataContext /*this*/);
        //    RaiseEvent(newEventArgs);
        //}

        //#endregion

        #region DependencyProperty


        public ICommand BackCommand
        {
            get
            {
                return (ICommand)GetValue(BackCommandProperty);
            }
            set
            {
                SetValue(BackCommandProperty, value);
            }
        }

        public static readonly DependencyProperty BackCommandProperty = DependencyProperty.Register(
            "BackCommand",
            typeof(ICommand),
            typeof(SubView),
            new FrameworkPropertyMetadata((ICommand)null, new PropertyChangedCallback(OnBackCommandPropertyChanged)));

        private static void OnBackCommandPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var uc = d as SubView;
            if (uc != null)
            {
                uc.OnBackCommandChanged(e.OldValue as ICommand, e.NewValue as ICommand);
            }
        }

        private void OnBackCommandChanged(ICommand oldContent, ICommand newContent)
        {
        }



        public object Header
        {
            get { return (object)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            "Header",
            typeof(object),
            typeof(SubView),
            new UIPropertyMetadata(null));



        public UIElement MenuBar
        {
            get { return (UIElement)GetValue(MenuBarProperty); }
            set { SetValue(MenuBarProperty, value); }
        }

        public static readonly DependencyProperty MenuBarProperty = DependencyProperty.Register(
            "MenuBar", 
            typeof(UIElement), 
            typeof(SubView), 
            new UIPropertyMetadata(null));

        #endregion
    }
}
