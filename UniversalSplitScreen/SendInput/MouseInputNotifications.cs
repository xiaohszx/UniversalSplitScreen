﻿using System;

namespace UniversalSplitScreen.SendInput
{
	//https://docs.microsoft.com/en-gb/windows/desktop/inputdev/mouse-input-notifications
	[Flags]
	enum MouseInputNotifications : ushort
	{
		/// <summary>
		/// https://docs.microsoft.com/en-gb/windows/desktop/inputdev/wm-mousemove
		/// </summary>
		WM_MOUSEMOVE = 0x0200,

		/// <summary>
		/// https://docs.microsoft.com/en-gb/windows/desktop/inputdev/wm-ncmousemove
		/// </summary>
		WM_NCMOUSEMOVE = 0x00A0,

		
		WM_LBUTTONUP = 0x0202,
		WM_LBUTTONDOWN = 0x0201,

		WM_MBUTTONDOWN = 0x0207,
		WM_MBUTTONUP = 0x0208,

		WM_RBUTTONDOWN = 0x0204,
		WM_RBUTTONUP = 0x0205,

		WM_MOUSEWHEEL = 0x020A,

		WM_NCHITTEST = 0x0084,

		WM_SETCURSOR = 0x0020,

		WM_MOUSEACTIVATE = 0x0021,

		WM_NCLBUTTONDOWN = 0x00A1,
		WM_NCLBUTTONUP = 0x00A2
	}
}
