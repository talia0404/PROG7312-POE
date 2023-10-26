using System;
using System.Windows.Forms;

namespace PROG_7312_Task_1_V1
{
	public class IDAreatimer
	{
		private System.Windows.Forms.Timer gameTimer; // Fully qualify Timer

		public event EventHandler TimerTick;

		public IDAreatimer()
		{
			InitializeTimer();
		}

		private void InitializeTimer()
		{
			gameTimer = new System.Windows.Forms.Timer();
			gameTimer.Tick += new EventHandler(GameTimer_Tick);
			gameTimer.Interval = 30000; // Default to 30 seconds
		}

		private void GameTimer_Tick(object sender, EventArgs e)
		{
			OnTimerTick();
			gameTimer.Stop();
		}

		public void StartTimer(int durationInSeconds)
		{
			gameTimer.Interval = durationInSeconds * 1000;
			gameTimer.Start();
		}

		public void StopTimer()
		{
			gameTimer.Stop();
		}

		public void ResetTimer()
		{
			gameTimer.Stop();
			gameTimer.Interval = 30000; // Reset to default 30 seconds
		}

		protected virtual void OnTimerTick()
		{
			TimerTick?.Invoke(this, EventArgs.Empty);
		}
	}
}

