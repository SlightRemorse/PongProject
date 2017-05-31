using System.ComponentModel;

namespace PongProject
{
    class ViewModel : INotifyPropertyChanged
    {
        private int leftPadPosition = 180;
        private int rightPadPosition = 180;
        private int leftResult = 0;
        private int rightResult = 0;
        private Ball ball = new Ball { XPosition = 380, YPosition = 210, IsDirectionRight = true };

        public int LeftPadPosition
        {
            get { return leftPadPosition; }
            set
            {
                leftPadPosition = value;
                OnPropertyChanged("LeftPadPosition");
            }
        }

        public int RightPadPosition
        {
            get { return rightPadPosition; }
            set
            {
                rightPadPosition = value;
                OnPropertyChanged("RightPadPosition");
            }
        }

        public int LeftResult
        {
            get { return leftResult; }
            set
            {
                leftResult = value;
                OnPropertyChanged("LeftResult");
            }
        }

        public int RightResult
        {
            get { return rightResult; }
            set
            {
                rightResult = value;
                OnPropertyChanged("RightResult");
            }
        }

        public double BallXPosition
        {
            get { return ball.XPosition; }
            set
            {
                ball.XPosition = value;
                OnPropertyChanged("BallXPosition");
            }
        }


        public double BallYPosition
        {
            get { return ball.YPosition; }
            set
            {
                ball.YPosition = value;
                OnPropertyChanged("BallYPosition");
            }
        }

        public bool IsBallDirectionRight
        {
            get { return ball.IsDirectionRight; }
            set
            {
                ball.IsDirectionRight = value;
                OnPropertyChanged("IsBallDirectionRight");
            }
        }


        public void changeBallDirection()
        {
            IsBallDirectionRight = !IsBallDirectionRight;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
