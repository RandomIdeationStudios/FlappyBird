// <copyright file="Achievements.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CloudOnce
{
    using System.Collections.Generic;
    using Internal;

    /// <summary>
    /// Provides access to achievements registered via the CloudOnce Editor.
    /// This file was automatically generated by CloudOnce. Do not edit.
    /// </summary>
    public static class Achievements
    {
        private static readonly UnifiedAchievement s_highScore25 = new UnifiedAchievement("HighScore25",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkI4OuQ2tkaEAIQBA"
#else
            "HighScore25"
#endif
            );

        public static UnifiedAchievement HighScore25
        {
            get { return s_highScore25; }
        }

        private static readonly UnifiedAchievement s_highScore50 = new UnifiedAchievement("HighScore50",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkI4OuQ2tkaEAIQBQ"
#else
            "HighScore50"
#endif
            );

        public static UnifiedAchievement HighScore50
        {
            get { return s_highScore50; }
        }

        private static readonly UnifiedAchievement s_highScore100 = new UnifiedAchievement("HighScore100",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkI4OuQ2tkaEAIQBg"
#else
            "HighScore100"
#endif
            );

        public static UnifiedAchievement HighScore100
        {
            get { return s_highScore100; }
        }

        public static readonly UnifiedAchievement[] All =
        {
            s_highScore25,
            s_highScore50,
            s_highScore100,
        };

        public static string GetPlatformID(string internalId)
        {
            return s_achievementDictionary.ContainsKey(internalId)
                ? s_achievementDictionary[internalId].ID
                : string.Empty;
        }

        private static readonly Dictionary<string, UnifiedAchievement> s_achievementDictionary = new Dictionary<string, UnifiedAchievement>
        {
            { "HighScore25", s_highScore25 },
            { "HighScore50", s_highScore50 },
            { "HighScore100", s_highScore100 },
        };
    }
}
