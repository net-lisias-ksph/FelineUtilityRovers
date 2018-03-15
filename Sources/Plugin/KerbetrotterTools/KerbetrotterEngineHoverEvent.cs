﻿/*
 * Copyright (C) 2018 Nils277 (https://github.com/Nils277)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using UnityEngine;

namespace KerbetrotterTools
{
    [KSPAddon(KSPAddon.Startup.Instantly, true)]
    class KerbetrotterEngineHoverEvent : MonoBehaviour
    {
        public static EventData<ModuleKerbetrotterEngine, bool, bool> onEngineHover;


        /// <summary>
        /// When the class awakes it inits all the filters it found for the KerbatrotterTools
        /// </summary>
        private void Awake()
        {
            onEngineHover = new EventData<ModuleKerbetrotterEngine, bool, bool>("onEngineHover");
        }
    }
}
