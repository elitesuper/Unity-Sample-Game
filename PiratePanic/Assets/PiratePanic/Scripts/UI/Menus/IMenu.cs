﻿/**
 * Copyright 2021 The Nakama Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace PiratePanic
{

	/// <summary>
	/// Interface implemented by <see cref="Menu"/> and <see cref="SingletonMenu{T}"/>.
	/// Declares common menu methods and <see cref="IMenu.IsShown"/> property.
	/// </summary>
	public interface IMenu
	{
		/// <summary>
		/// If true, object implementing <see cref="IMenu"/> is currently shown.
		/// </summary>
		bool IsShown { get; }

		/// <summary>
		/// Shows this menu to the user.
		/// </summary>
		void Show(bool isMuteButtonClick = false);

		/// <summary>
		/// Hides this menu from the user.
		/// </summary>
		void Hide(bool isMuteSoundManager = false);

		/// <summary>
		/// Sets the listener of this menu's back button.
		/// </summary>
		void SetBackButtonHandler(Action onBack);
	}
}