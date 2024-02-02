using System.Diagnostics;
using WinFormsTimer = System.Windows.Forms.Timer;
using WindowsInput;
using WindowsInput.Native;

namespace AntiAFK
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static bool keepAlive = true;
        public static Stopwatch durationTimer = new();
        public static WinFormsTimer updateTimer = new();

        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new App());
        }

        public static async Task SimulateKeystrokes(decimal uInput)
        {
            int uInputToInt = Convert.ToInt32(uInput);
            int loopDelay = uInputToInt * 60000;
            string[] keystrokes = { "W", "A", "S", "D", " " }; // Here are the keystrokes that will be used
            InputSimulator inputSimulator = new();

            while (keepAlive)
            {
                foreach (string keystroke in keystrokes)
                {
                    if (!keepAlive)
                        break;

                    VirtualKeyCode keyCode = GetVirtualKeyCode(keystroke);

                    inputSimulator.Keyboard.KeyDown(keyCode); // Press the key
                    await Task.Delay(5000); // Hold the key for 5 seconds
                    inputSimulator.Keyboard.KeyUp(keyCode); // Release the key

                    // If the keystroke is not a space, introduce a delay before the next keypress
                    if (keystroke != " ")
                    {
                        await Task.Delay(1000); // Delay before the next keypress
                    }
                    else
                    {
                        await Task.Delay(loopDelay); // If the keystroke is a space, delay before repeating the loop
                    }
                }
            }
        }

        private static VirtualKeyCode GetVirtualKeyCode(string key)
        {
            // Map the key string to the corresponding virtual key code
            return key.ToUpper() switch
            {
                "W" => VirtualKeyCode.VK_W,
                "A" => VirtualKeyCode.VK_A,
                "S" => VirtualKeyCode.VK_S,
                "D" => VirtualKeyCode.VK_D,
                " " => VirtualKeyCode.SPACE,
                _ => throw new ArgumentException($"Unsupported key: {key}"),
            };
        }

        /// <summary>
        ///     Show a start message to give enough time to switch the target to the foreground 
        /// </summary>
        public static async Task StartMessage(ToolStripStatusLabel statusLabel)
        {
            int countdownValue = 5;
            string startMessage;

            while (countdownValue >= 0)
            {
                startMessage = $"Ready in {countdownValue} seconds";
                statusLabel.Text = startMessage;
                countdownValue--;
                await AddDelay(1000);
            }
        }

        public static async Task AddDelay(int ms)
        {
            await Task.Delay(ms);
        }

        public static void RunningMessage(ToolStripStatusLabel statusLabel)
        {
            string runningMessage = "The program is running!";
            statusLabel.Text = runningMessage;
        }

        public static void StopMessage(ToolStripStatusLabel statusLabel)
        {
            string stopMessage = "Stopping program. . .";
            statusLabel.Text = stopMessage;
        }

        public static void ResetMessage(ToolStripStatusLabel statusLabel)
        {
            string resetMessage = "Click start to begin";
            statusLabel.Text = resetMessage;
        }

        public static void EnableButton(Button btn)
        {
            btn.Enabled = true;
        }

        public static void DisableButton(Button btn)
        {
            btn.Enabled = false;
        }

        public static void StartTimer(ToolStripStatusLabel statusLabel)
        {
            if (!durationTimer.IsRunning)
            {
                durationTimer.Start();
                updateTimer.Interval = 1000; // Set the timer interval to 1000 ms
                updateTimer.Tick += (sender, eventArg) => UpdateTimerDisplay(statusLabel, false);
                updateTimer.Start(); // Start the timer
            }
            statusLabel.Text = $"Runtime: {durationTimer.Elapsed:hh\\:mm\\:ss}";
        }

        public static void ResetTimer(ToolStripStatusLabel statusLabel)
        {
            durationTimer.Reset();
            updateTimer.Stop(); // Stop the timer
            UpdateTimerDisplay(statusLabel, true); // Update the display after resetting
        }

        public static void UpdateTimerDisplay(ToolStripStatusLabel statusLabel, Boolean reset = false)
        {
            if (!reset)
            {
                // Update the label/status bar with the formatted elapsed time
                statusLabel.Text = $"Runtime: {durationTimer.Elapsed:hh\\:mm\\:ss}";
            }
            else
            {
                statusLabel.Text = $"";
            }
            
        }

    }

}