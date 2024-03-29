﻿namespace TheChest.Slots.Generics.Interfaces
{
    /// <summary>
    /// Interface only with properties for a basic Slot
    /// </summary>
    /// <typeparam name="T">Item the Slot Accept</typeparam>
    public interface ISlot<T>
    {
        /// <summary>
        /// The current item inside the slot
        /// </summary>
        T CurrentItem { get; }

        /// <summary>
        /// Verify if the slot is full
        /// </summary>
        bool IsFull { get;}

        /// <summary>
        /// Verify if the current slot is empty
        /// </summary>
        bool IsEmpty { get; }
    }
}
