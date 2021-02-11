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

using System.Collections.Generic;


namespace PiratePanic
{

	/// <summary>
	/// Contains data about spell activation
	/// </summary>
	public class MatchMessageSpellActivated : MatchMessage<MatchMessageSpellActivated>
	{
		public readonly string OwnerId;
		public readonly SpellType SpellType;
		public readonly int NodeX;
		public readonly int NodeY;
		public readonly List<int> ImpactedUnitsIds;

		public MatchMessageSpellActivated(string ownerId, SpellType spellType, int nodeX, int nodeY, List<int> impactedUnitsIds)
		{
			OwnerId = ownerId;
			SpellType = spellType;
			NodeX = nodeX;
			NodeY = nodeY;
			ImpactedUnitsIds = impactedUnitsIds;
		}
	}
}
