// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Iniciando o KeepMoveMouse, by Sajermann");
[DllImport("user32.dll")]
static extern bool SetCursorPos(int X, int Y);

[System.Runtime.InteropServices.DllImport("user32.dll")]
static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

const int MOUSEEVENTF_LEFTDOWN = 0x02;
const int MOUSEEVENTF_LEFTUP = 0x04;

//This simulates a left mouse click
static void LeftMouseClick(int xpos, int ypos)
{
  SetCursorPos(xpos, ypos);
  mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
  mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
}


while (true)
{
  SetCursorPos(0, 0);
  await Task.Delay(2000);
  SetCursorPos(500, 500);
  LeftMouseClick(500, 500);
  await Task.Delay(2000);
}