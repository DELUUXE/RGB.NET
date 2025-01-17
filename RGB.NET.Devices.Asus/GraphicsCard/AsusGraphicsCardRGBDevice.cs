﻿using RGB.NET.Core;

namespace RGB.NET.Devices.Asus;

/// <inheritdoc cref="AsusRGBDevice{TDeviceInfo}" />
/// <summary>
/// Represents a Asus graphicsCard.
/// </summary>
public class AsusGraphicsCardRGBDevice : AsusRGBDevice<AsusRGBDeviceInfo>, IGraphicsCard
{
    #region Constructors

    /// <inheritdoc />
    /// <summary>
    /// Initializes a new instance of the <see cref="T:RGB.NET.Devices.Asus.AsusGraphicsCardRGBDevice" /> class.
    /// </summary>
    /// <param name="info">The specific information provided by Asus for the graphics card.</param>
    /// <param name="updateTrigger">The update trigger used to update this device.</param>
    internal AsusGraphicsCardRGBDevice(AsusRGBDeviceInfo info, IDeviceUpdateTrigger updateTrigger)
        : base(info, updateTrigger)
    {
        InitializeLayout();
    }

    #endregion

    #region Methods

    private void InitializeLayout()
    {
        int ledCount = DeviceInfo.Device.Lights.Count;
        for (int i = 0; i < ledCount; i++)
            AddLed(LedId.GraphicsCard1 + i, new Point(i * 10, 0), new Size(10, 10));
    }

    /// <inheritdoc />
    protected override object? GetLedCustomData(LedId ledId) => (int)ledId - (int)LedId.GraphicsCard1;

    #endregion
}