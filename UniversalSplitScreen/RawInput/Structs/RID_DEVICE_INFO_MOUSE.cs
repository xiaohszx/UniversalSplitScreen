﻿using System.Runtime.InteropServices;

namespace UniversalSplitScreen.RawInput
{
	//https://docs.microsoft.com/en-us/windows/desktop/api/winuser/ns-winuser-tagrid_device_info_mouse
	[StructLayout(LayoutKind.Sequential)]
	public struct RID_DEVICE_INFO_MOUSE
	{
		/// <summary>
		/// The identifier of the mouse device.
		/// </summary>
		public uint dwId;

		/// <summary>
		/// The number of buttons for the mouse.
		/// </summary>
		public uint dwNumberOfButtons;

		/// <summary>
		/// The number of data points per second. This information may not be applicable for every mouse device.
		/// </summary>
		public uint dwSampleRate;

		/// <summary>
		/// TRUE if the mouse has a wheel for horizontal scrolling; otherwise, FALSE.
		/// </summary>
		public bool fHasHorizontalWheel;
	}
}
