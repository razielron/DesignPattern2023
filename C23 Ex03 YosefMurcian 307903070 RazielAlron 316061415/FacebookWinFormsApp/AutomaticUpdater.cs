using System;
using System.Threading;

namespace BasicFacebookFeatures
{
    class AutomaticUpdater
    {
        public event Action m_EntityUpdateAction;
        private System.Timers.Timer m_Timer;

        public AutomaticUpdater()
        {
            m_Timer = new System.Timers.Timer();
            m_Timer.Elapsed += updateEntities;
            m_Timer.AutoReset = true;
        }

        public void StopTimer()
        {
            m_Timer.Stop();
        }

        public void StartTimer(int i_DurationInMinutes)
        {
            m_Timer.Stop();
            m_Timer.Interval = i_DurationInMinutes * 1000 * 60;
            m_Timer.Start();
        }

        private void updateEntities(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (m_EntityUpdateAction != null)
            {
                foreach(Delegate observerDelegate in m_EntityUpdateAction.GetInvocationList())
                {
                    Action action = (Action)observerDelegate;
                    new Thread(action.Invoke).Start();
                }
            }
        }
    }
}
