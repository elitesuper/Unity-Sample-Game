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
using System.Collections.Generic;



namespace PiratePanic
{

	/// <summary>
	/// Base class for spells
	/// </summary>
	public interface ISpell
	{
		event Action<ISpell> OnHide;

		SpellType SpellType { get; }

		void Activate(Node node, string playerId);

		void MakeImpactOnUnits(List<Unit> units);

		void Show(Node node);

		void Hide();
	}
}