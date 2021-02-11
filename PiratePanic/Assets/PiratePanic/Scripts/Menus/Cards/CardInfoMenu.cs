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

using UnityEngine;
using UnityEngine.UI;

namespace PiratePanic
{
    /// <summary>
    /// Popup window displaying informations of supplied <see cref="CardData"/>.
    /// </summary>
    public class CardInfoMenu : Menu
	{
		/// <summary>
		/// Textfield displaying the name of <see cref="_displayedCard"/>.
		/// </summary>
		[SerializeField] private Text _cardName = null;

		/// <summary>
		/// Textfield displaying the level of <see cref="_displayedCard"/>.
		/// </summary>
		[SerializeField] private Text _cardLevel = null;

		/// <summary>
		/// Textfield displaying the description of <see cref="_displayedCard"/>.
		/// </summary>
		[SerializeField] private Text _cardDescription = null;

		/// <summary>
		/// The image representing <see cref="_displayedCard"/>.
		/// </summary>
		[SerializeField] private Image _cardImage = null;

		/// <summary>
		/// The card this <see cref="CardInfoMenu"/> is displaying info of.
		/// Can be set by invoking <see cref="SetCard(CardData)"/> method.
		/// </summary>
		private CardData _displayedCard;

		/// <summary>
		/// Sets the card to be displayed by this menu.
		/// </summary>
		public void SetCard(CardData card)
		{
			_displayedCard = card;
			_cardLevel.text = card.level.ToString();
			_cardName.text = card.GetCardInfo().Name;
			_cardDescription.text = card.GetCardInfo().Description;
			_cardImage.sprite = card.GetCardInfo().Sprite;
		}
	}
}
