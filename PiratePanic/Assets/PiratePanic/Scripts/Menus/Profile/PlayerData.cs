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

using System.Runtime.Serialization;

namespace PiratePanic
{
	/// <summary>
	/// Data model stored using Nakama storage engine. Contains basic player data.
	/// </summary>
	public class PlayerData
	{
		/// <summary>
		/// Current level of this player.
		/// </summary>
		[DataMember] public int level = 1;

		/// <summary>
		/// The number of games this player won.
		/// </summary>
		[DataMember] public int wins = 0;

		/// <summary>
		/// The number of games this player participated in.
		/// </summary>
		[DataMember] public int gamesPlayed = 0;
	}
}