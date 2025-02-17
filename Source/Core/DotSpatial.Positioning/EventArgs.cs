// Copyright (c) DotSpatial Team. All rights reserved.
// Licensed under the MIT, license. See License.txt file in the project root for full license information.

using System;

namespace DotSpatial.Positioning
{
    /// <summary>
    /// Represents information about an angle when an angle-related event is raised.
    /// </summary>
    /// <example>
    /// This example demonstrates how to use <strong>AngleEventArgs</strong> when raising
    /// an event.
    ///   <code lang="VB">
    /// ' Declare a new event
    /// Dim MyAngleEvent As AngleEventHandler
    /// Sub Main()
    /// ' Create an angle of 90�
    /// Dim MyAngle As New Angle(90);
    /// ' Raise our custom Event
    /// RaiseEvent MyAngleEvent(Me, New AngleEventArgs(MyAngle));
    /// End Sub
    ///   </code>
    ///   <code lang="CS">
    /// // Declare a new event
    /// AngleEventHandler MyAngleEvent;
    /// void Main()
    /// {
    /// // Create an angle of 90�
    /// Angle MyAngle = new Angle(90);
    /// // Raise our custom event
    /// if (MyAngleEvent != null)
    /// MyAngleEvent(this, new AngleEventArgs(MyAngle));
    /// }
    ///   </code>
    ///   </example>
    ///
    /// <seealso cref="Angle">Angle Class</seealso>
    /// <remarks>This class is used for events which use an <strong>Angle</strong> as a
    /// parameter.</remarks>
    public sealed class AngleEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified Angle object.
        /// </summary>
        /// <param name="angle">The angle.</param>
        public AngleEventArgs(Angle angle)
        {
            Angle = angle;
        }

        /// <summary>
        /// Represents information about an angular measurement when an angle-related event is raised.
        /// </summary>
        /// <value>An <strong>Angle</strong> object containing a property which has changed.</value>
        /// <seealso cref="Angle">Angle Class</seealso>
        /// <remarks>This class is used by the <see cref="Angle">Angle</see> class to provide notification when hours, minutes, or seconds properties have changed.</remarks>
        public Angle Angle { get; }
    }

    /// <summary>
    /// Represents information about a area when an area-related event is raised.
    /// </summary>
    /// <example>
    /// This example demonstrates how to use the <strong>AreaEventArgs</strong> class when
    /// raising an event.
    ///   <code lang="VB">
    /// ' Declare a new event
    /// Dim MyAreaEvent As AreaEventHandler
    /// Sub Main()
    /// ' Create a Area of 125 kilometers
    /// Dim MyArea As New Area(125, AreaUnit.SquareKilometers)
    /// ' Raise our custom event
    /// RaiseEvent MyAreaEvent(Me, New AreaEventArgs(MyArea))
    /// End Sub
    ///   </code>
    ///   <code lang="CS">
    /// // Declare a new event
    /// AreaEventHandler MyAreaEvent;
    /// void Main()
    /// {
    /// // Create a Area of 125 kilometers
    /// Area MyArea = new Area(125, AreaUnit.SquareKilometers);
    /// // Raise our custom event
    /// if (MyAreaEvent != null)
    /// MyAreaEvent(this, New AreaEventArgs(MyArea));
    /// }
    ///   </code>
    ///   </example>
    ///
    /// <seealso cref="Area">Area Class</seealso>
    public sealed class AreaEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified Area object.
        /// </summary>
        /// <param name="value">The value.</param>
        public AreaEventArgs(Area value)
        {
            Area = value;
        }

        /// <summary>
        /// Represents information about a Area measurement when an Area-related event is raised.
        /// </summary>
        /// <value>A <strong>Area</strong> object containing a property which has changed.</value>
        /// <seealso cref="Area">Area Class</seealso>
        /// <remarks>This class is used by the <see cref="Area">Area</see> class to provide notification
        /// when hours, minutes, or seconds properties have changed.</remarks>
        public Area Area { get; }
    }

    /// <summary>
    /// Represents information about an angle when an angle-related event is raised.
    /// </summary>
    /// <example>
    /// This example demonstrates how to use <strong>AzimuthEventArgs</strong> when raising
    /// an event.
    ///   <code lang="VB">
    /// ' Declare a new event
    /// Dim MyAzimuthEvent As AzimuthEventHandler
    /// Sub Main()
    /// ' Create an angle of 90�
    /// Dim MyAzimuth As New Azimuth(90);
    /// ' Raise our custom Event
    /// RaiseEvent MyAzimuthEvent(Me, New AzimuthEventArgs(MyAzimuth));
    /// End Sub
    ///   </code>
    ///   <code lang="CS">
    /// // Declare a new event
    /// AzimuthEventHandler MyAzimuthEvent;
    /// void Main()
    /// {
    /// // Create an angle of 90�
    /// Azimuth MyAzimuth = new Azimuth(90);
    /// // Raise our custom event
    /// if (MyAzimuthEvent != null)
    /// MyAzimuthEvent(this, new AzimuthEventArgs(MyAzimuth));
    /// }
    ///   </code>
    ///   </example>
    ///
    /// <seealso cref="Azimuth">Azimuth Class</seealso>
    /// <remarks>This class is used for events which use an <strong>Azimuth</strong> as a
    /// parameter.</remarks>
    public sealed class AzimuthEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified Azimuth object.
        /// </summary>
        /// <param name="angle">The angle.</param>
        public AzimuthEventArgs(Azimuth angle)
        {
            Azimuth = angle;
        }

        /// <summary>
        /// Represents information about an angular measurement when an angle-related event is raised.
        /// </summary>
        /// <value>An <strong>Azimuth</strong> object containing a property which has changed.</value>
        /// <seealso cref="Azimuth">Azimuth Class</seealso>
        /// <remarks>This class is used by the <see cref="Azimuth">Azimuth</see> class to provide notification when hours, minutes, or seconds properties have changed.</remarks>
        public Azimuth Azimuth { get; }
    }

    /// <summary>
    ///
    /// </summary>
    public sealed class CancelableEventArgs : EventArgs
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelableEventArgs"/> class.
        /// </summary>
        /// <param name="isCanceled">if set to <c>true</c> [is canceled].</param>
        public CancelableEventArgs(bool isCanceled)
        {
            Canceled = isCanceled;
        }

        /// <summary>
        /// Controls whether an operation is to be aborted.
        /// </summary>
        /// <value><c>true</c> if canceled; otherwise, <c>false</c>.</value>
        /// <remarks>This property, when set to True will signal that a pending operation should not execute.  For example,
        /// an event which is raised immediately before connecting would check this property to determine whether to
        /// continue connecting, or exit.</remarks>
        public bool Canceled { get; set; }
    }

    /// <summary>
    /// Represents information about a distance when an distance-related event is raised.
    /// </summary>
    /// <example>This example demonstrates how to use this class when raising an event.
    ///   <code lang="VB">
    /// ' Declare a new event
    /// Dim MyDistanceEvent As DistanceEventHandler
    /// ' Create a distance of 125 kilometers
    /// Dim MyDistance As New Distance(125, DistanceUnit.Kilometers)
    /// Sub Main()
    /// ' Raise our custom event
    /// RaiseEvent MyDistanceEvent(Me, New DistanceEventArgs(MyDistance))
    /// End Sub
    ///   </code>
    ///   <code lang="C#">
    /// // Declare a new event
    /// DistanceEventHandler MyDistanceEvent;
    /// // Create a distance of 125 kilometers
    /// Distance MyDistance = new Distance(125, DistanceUnit.Kilometers);
    /// void Main()
    /// {
    /// // Raise our custom event
    /// MyDistanceEvent(this, New DistanceEventArgs(MyDistance));
    /// }
    ///   </code>
    ///   </example>
    ///
    /// <seealso cref="Distance">Distance Class</seealso>
    /// <remarks>This class is typically used for events in the <see cref="Distance">Distance</see> class to
    /// provide notification when hours, minutes, decimal minutes or seconds properties have changed.</remarks>
    public sealed class DistanceEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified Distance object.
        /// </summary>
        /// <param name="value">The value.</param>
        public DistanceEventArgs(Distance value)
        {
            Distance = value;
        }

        /// <summary>
        /// Represents information about a distance measurement when an distance-related event is raised.
        /// </summary>
        /// <value>A <strong>Distance</strong> object containing a property which has changed.</value>
        /// <seealso cref="Distance">Distance Class</seealso>
        /// <remarks>This class is used by the <see cref="Distance">Distance</see> class to provide notification
        /// when hours, minutes, or seconds properties have changed.</remarks>
        ////[CLSCompliant(false)]
        public Distance Distance { get; }
    }

    /// <summary>
    /// Represents information about an angle when an angle-related event is raised.
    /// </summary>
    /// <example>
    /// This example demonstrates how to use <strong>ElevationEventArgs</strong> when raising
    /// an event.
    ///   <code lang="VB">
    /// ' Declare a new event
    /// Dim MyElevationEvent As ElevationEventHandler
    /// Sub Main()
    /// ' Create an angle of 90�
    /// Dim MyElevation As New Elevation(90);
    /// ' Raise our custom Event
    /// RaiseEvent MyElevationEvent(Me, New ElevationEventArgs(MyElevation));
    /// End Sub
    ///   </code>
    ///   <code lang="CS">
    /// // Declare a new event
    /// ElevationEventHandler MyElevationEvent;
    /// void Main()
    /// {
    /// // Create an angle of 90�
    /// Elevation MyElevation = new Elevation(90);
    /// // Raise our custom event
    /// if (MyElevationEvent != null)
    /// MyElevationEvent(this, new ElevationEventArgs(MyElevation));
    /// }
    ///   </code>
    ///   </example>
    ///
    /// <seealso cref="Elevation">Elevation Class</seealso>
    /// <remarks>This class is used for events which use an <strong>Elevation</strong> as a
    /// parameter.</remarks>
    public sealed class ElevationEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified Elevation object.
        /// </summary>
        /// <param name="angle">The angle.</param>
        public ElevationEventArgs(Elevation angle)
        {
            Elevation = angle;
        }

        /// <summary>
        /// Represents information about an angular measurement when an angle-related event is raised.
        /// </summary>
        /// <value>An <strong>Elevation</strong> object containing a property which has changed.</value>
        /// <seealso cref="Elevation">Elevation Class</seealso>
        /// <remarks>This class is used by the <see cref="Elevation">Elevation</see> class to provide notification when hours, minutes, or seconds properties have changed.</remarks>
        public Elevation Elevation { get; }
    }

    // public sealed class GeographicRectangleEventArgs : EventArgs
    //{
    //    private GeographicRectangle _Rectangle;

    //    public GeographicRectangleEventArgs(GeographicRectangle rectangle)
    //    {
    //        _Rectangle = rectangle;
    //    }

    //    public GeographicRectangle GeographicRectangle
    //    {
    //        get
    //        {
    //            return _Rectangle;
    //        }
    //    }
    //}

    /// <summary>
    /// Represents information about an angle when an angle-related event is raised.
    /// </summary>
    /// <example>
    /// This example demonstrates how to use <strong>LatitudeEventArgs</strong> when raising
    /// an event.
    ///   <code lang="VB">
    /// ' Declare a new event
    /// Dim MyLatitudeEvent As LatitudeEventHandler
    /// Sub Main()
    /// ' Create an angle of 90�
    /// Dim MyLatitude As New Latitude(90);
    /// ' Raise our custom Event
    /// RaiseEvent MyLatitudeEvent(Me, New LatitudeEventArgs(MyLatitude));
    /// End Sub
    ///   </code>
    ///   <code lang="CS">
    /// // Declare a new event
    /// LatitudeEventHandler MyLatitudeEvent;
    /// void Main()
    /// {
    /// // Create an angle of 90�
    /// Latitude MyLatitude = new Latitude(90);
    /// // Raise our custom event
    /// if (MyLatitudeEvent != null)
    /// MyLatitudeEvent(this, new LatitudeEventArgs(MyLatitude));
    /// }
    ///   </code>
    ///   </example>
    ///
    /// <seealso cref="Latitude">Latitude Class</seealso>
    /// <remarks>This class is used for events which use an <strong>Latitude</strong> as a
    /// parameter.</remarks>
    public sealed class LatitudeEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified Latitude object.
        /// </summary>
        /// <param name="angle">The angle.</param>
        public LatitudeEventArgs(Latitude angle)
        {
            Latitude = angle;
        }

        /// <summary>
        /// Represents information about an angular measurement when an angle-related event is raised.
        /// </summary>
        /// <value>An <strong>Latitude</strong> object containing a property which has changed.</value>
        /// <seealso cref="Latitude">Latitude Class</seealso>
        /// <remarks>This class is used by the <see cref="Latitude">Latitude</see> class to provide notification when hours, minutes, or seconds properties have changed.</remarks>
        public Latitude Latitude { get; }
    }

    /// <summary>
    /// Represents information about an angle when an angle-related event is raised.
    /// </summary>
    /// <example>
    /// This example demonstrates how to use <strong>LongitudeEventArgs</strong> when raising
    /// an event.
    ///   <code lang="VB">
    /// ' Declare a new event
    /// Dim MyLongitudeEvent As LongitudeEventHandler
    /// Sub Main()
    /// ' Create an angle of 90�
    /// Dim MyLongitude As New Longitude(90);
    /// ' Raise our custom Event
    /// RaiseEvent MyLongitudeEvent(Me, New LongitudeEventArgs(MyLongitude));
    /// End Sub
    ///   </code>
    ///   <code lang="CS">
    /// // Declare a new event
    /// LongitudeEventHandler MyLongitudeEvent;
    /// void Main()
    /// {
    /// // Create an angle of 90�
    /// Longitude MyLongitude = new Longitude(90);
    /// // Raise our custom event
    /// if (MyLongitudeEvent != null)
    /// MyLongitudeEvent(this, new LongitudeEventArgs(MyLongitude));
    /// }
    ///   </code>
    ///   </example>
    ///
    /// <seealso cref="Longitude">Longitude Class</seealso>
    /// <remarks>This class is used for events which use an <strong>Longitude</strong> as a
    /// parameter.</remarks>
    public sealed class LongitudeEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified Longitude object.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        public LongitudeEventArgs(Longitude longitude)
        {
            Longitude = longitude;
        }

        /// <summary>
        /// Represents information about an angular measurement when an angle-related event is raised.
        /// </summary>
        /// <value>An <strong>Longitude</strong> object containing a property which has changed.</value>
        /// <seealso cref="Longitude">Longitude Class</seealso>
        /// <remarks>This class is used by the <see cref="Longitude">Longitude</see> class to provide notification when hours, minutes, or seconds properties have changed.</remarks>
        public Longitude Longitude { get; }
    }

    /*
    public sealed class PolarCoordinateEventArgs : EventArgs
    {
        private PolarCoordinate _PolarCoordinate;

        public PolarCoordinateEventArgs(PolarCoordinate polarCoordinate)
            : base()
        {
            _PolarCoordinate = polarCoordinate;
        }

        public PolarCoordinate PolarCoordinate
        {
            get
            {
                return _PolarCoordinate;
            }
        }
    }

    public sealed class PolarCoordinateOrientationEventArgs : EventArgs
    {
        private PolarCoordinateOrientation _PolarCoordinateOrientation;

        public PolarCoordinateOrientationEventArgs(PolarCoordinateOrientation polarCoordinateOrientation)
            : base()
        {
            _PolarCoordinateOrientation = polarCoordinateOrientation;
        }

        public PolarCoordinateOrientation PolarCoordinateOrientation
        {
            get
            {
                return _PolarCoordinateOrientation;
            }
        }
    }
     */

    /// <summary>
    ///
    /// </summary>
    public sealed class PositionEventArgs : EventArgs
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionEventArgs"/> class.
        /// </summary>
        /// <param name="position">The position.</param>
        public PositionEventArgs(Position position)
        {
            Position = position;
        }

        /// <summary>
        /// Gets the position.
        /// </summary>
        public Position Position { get; }
    }

    /// <summary>
    ///
    /// </summary>
    public sealed class RadianEventArgs : EventArgs
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RadianEventArgs"/> class.
        /// </summary>
        /// <param name="radian">The radian.</param>
        public RadianEventArgs(Radian radian)
        {
            Radians = radian;
        }

        /// <summary>
        /// Gets the radians.
        /// </summary>
        public Radian Radians { get; }
    }

    /// <summary>
    ///
    /// </summary>
    public sealed class SpeedEventArgs : EventArgs
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedEventArgs"/> class.
        /// </summary>
        /// <param name="speed">The speed.</param>
        public SpeedEventArgs(Speed speed)
        {
            Speed = speed;
        }

        /// <summary>
        /// Gets the speed.
        /// </summary>
        public Speed Speed { get; }
    }

    /// <summary>
    ///
    /// </summary>
    public sealed class TimeSpanEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified TimeSpan object.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <seealso cref="TimeSpan">TimeSpan Property</seealso>
        ///
        /// <seealso cref="System.TimeSpan">TimeSpan Structure</seealso>
        public TimeSpanEventArgs(TimeSpan timeSpan)
        {
            TimeSpan = timeSpan;
        }

        /// <summary>
        /// Indicates a length of time which is the target of the event.
        /// </summary>
        /// <value>A <strong>TimeSpan</strong> object describing a length of time.</value>
        /// <seealso cref="System.TimeSpan">TimeSpan Structure</seealso>
        public TimeSpan TimeSpan { get; }
    }

    /// <summary>
    /// Represents information about the date and time reported by the GPS device.
    /// </summary>
    public sealed class DateTimeEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public DateTimeEventArgs(DateTime dateTime)
        {
            DateTime = dateTime;
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="systemClockUpdated">if set to <c>true</c> [system clock updated].</param>
        public DateTimeEventArgs(DateTime dateTime, bool systemClockUpdated)
        {
            DateTime = dateTime;
            SystemClockUpdated = systemClockUpdated;
        }

        /// <summary>
        /// A date and time value in UTC time (not adjusted for the local time zone).
        /// </summary>
        /// <value>A DateTime object containing a date and time reported by the GPS device.</value>
        /// <seealso cref="System.DateTime">DateTime Class</seealso>
        ///
        /// <seealso cref="System.DateTime.ToLocalTime">ToLocalTime Method (DateTime Class)</seealso>
        /// <remarks>This date and time value is not adjusted to the local time zone.  Use the
        /// <see cref="System.DateTime.ToLocalTime">ToLocalTime</see> method to adjust to local time.</remarks>
        public DateTime DateTime { get; }

        /// <summary>
        /// Indicates whether the system clock updated to match the <see cref="DateTime"/>.
        /// </summary>
        /// <value><see langword="true">True</see> if the system clock was updated; otherwise, <see langword="false"/>.
        /// The default is <see langword="false"/>.</value>
        public bool SystemClockUpdated { get; }
    }

    /// <summary>
    /// Represents information about an exception when an error-related event is raised.
    /// </summary>
    /// <example>This example demonstrates how to use this class when raising an event.
    ///   <code lang="VB">
    /// ' Create a new exception
    /// Dim MyException As New ApplicationException("The error was successfully created.")
    /// ' Declare a new event
    /// Dim MyErrorEvent As ExceptionEventHandler
    /// Sub Main()
    /// ' Raise our custom event
    /// RaiseEvent MyErrorEvent(Me, New ExceptionEventArgs(MyException))
    /// End Sub
    ///   </code>
    ///   <code lang="C#">
    /// // Create a new exception
    /// ApplicationException MyException = new ApplicationException("The error was successfully created.")
    /// // Declare a new event
    /// ExceptionEventHandler MyErrorEvent;
    /// void Main()
    /// {
    /// // Raise our custom event
    /// MySatelliteEvent(this, New ExceptionEventArgs(MyException));
    /// }
    ///   </code>
    ///   </example>
    /// <remarks>This object is used throughout the GPS.NET framework to provide notification when
    /// either of two situations occur:
    /// <list>
    /// 		<item>An exception is thrown which cannot be trapped via a Try..Catch block (such as from a separate thread)</item>
    /// 		<item>An exception is thrown which can be recovered from and should not halt the current operation.</item>
    /// 	</list>
    /// Most frequently, this class is used when a parsing exception occurs via the Parse method or during automatic
    /// data collection.</remarks>
    public class ExceptionEventArgs : EventArgs
    {

        /// <summary>
        /// Creates a new instance containing the specified exception object.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public ExceptionEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Indicates information about the error and its location within a module.
        /// </summary>
        /// <value>An <strong>ApplicationException</strong> object or derivative describing the error.</value>
        public Exception Exception { get; }
    }

    /// <summary>
    ///
    /// </summary>
    public class ProgressEventArgs : EventArgs
    {

        /// <summary>
        ///
        /// </summary>
        public static new readonly ProgressEventArgs Empty = new(0, 0);

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressEventArgs"/> class.
        /// </summary>
        /// <param name="total">The total.</param>
        public ProgressEventArgs(int total)
        {
            Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressEventArgs"/> class.
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="total">The total.</param>
        public ProgressEventArgs(int current, int total)
        {
            Current = current;
            Total = total;
        }

        /// <summary>
        /// Gets the total.
        /// </summary>
        public int Total { get; }

        /// <summary>
        /// Gets the current.
        /// </summary>
        public int Current { get; }
    }
}