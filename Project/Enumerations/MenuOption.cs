﻿// ******************************************************************************************
//     Assembly:                Kitty
//     Author:                  Terry D. Eppler
//     Created:                 10-31-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        10-31-2024
// ******************************************************************************************
// <copyright file="MenuOption.cs" company="Terry D. Eppler">
//   Kitty is an open source windows (wpf) application that interacts with OpenAI GPT-3.5 Turbo API
//   based on NET6 and written in C-Sharp.
// 
//    Copyright ©  2020-2024 Terry D. Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   MenuOption.cs
// </summary>
// ******************************************************************************************

namespace Kitty
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public enum MenuOption
    {
        /// <summary>
        /// The file
        /// </summary>
        File = 1,

        /// <summary>
        /// The folder
        /// </summary>
        Folder = 2,

        /// <summary>
        /// The calculator
        /// </summary>
        Calculator = 3,

        /// <summary>
        /// The calendar
        /// </summary>
        Calendar = 5,

        /// <summary>
        /// The control panel
        /// </summary>
        ControlPanel = 7,

        /// <summary>
        /// The task manager
        /// </summary>
        TaskManager = 8,

        /// <summary>
        /// The windows maps
        /// </summary>
        Maps = 9,

        /// <summary>
        /// The windows media player
        /// </summary>
        MediaPlayer = 10,

        /// <summary>
        /// The one drive
        /// </summary>
        Storage = 11,

        /// <summary>
        /// The windows clock
        /// </summary>
        Clock = 12,

        /// <summary>
        /// The guidance
        /// </summary>
        Documentation = 13,

        /// <summary>
        /// The fire fox
        /// </summary>
        Firefox = 14,

        /// <summary>
        /// The chrome
        /// </summary>
        Chrome = 15,

        /// <summary>
        /// The edge
        /// </summary>
        Edge = 16,

        /// <summary>
        /// The save
        /// </summary>
        Save = 17,

        /// <summary>
        /// The refresh
        /// </summary>
        Refresh = 18,

        /// <summary>
        /// The exit
        /// </summary>
        Exit = 19
    }
}