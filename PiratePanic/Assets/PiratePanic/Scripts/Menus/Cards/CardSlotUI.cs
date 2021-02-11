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
using UnityEngine;
using UnityEngine.UI;

namespace PiratePanic
{
	/// <summary>
	/// Visual representation of a card shown in <see cref="DeckBuildingMenu"/>.
	/// </summary>
	public class CardSlotUI : MonoBehaviour
	{

		/// <summary>
		/// Image representing the card.
		/// </summary>
		[SerializeField] private Image _image = null;

		/// <summary>
		/// Image representing the background of a card.
		/// </summary>
		[SerializeField] private Image _background = null;

		/// <summary>
		/// Button used to select this card to show its stats and options
		/// in the <see cref="CardInfoSidePanel"/>.
		/// </summary>
		[SerializeField] private Button _selectButton = null;

		/// <summary>
		/// Textfield containing the level of this card.
		/// </summary>
		[SerializeField] private Text _levelText = null;

		/// <summary>
		/// Textfield displaying the card cost.
		/// </summary>
		[SerializeField] private Text _cost = null;

		/// <summary>
		/// Color of <see cref="_background"/> when this slot is selected.
		/// </summary>
		[SerializeField] private Color _selectedColor = Color.black;

		/// <summary>
		/// Reference to the card this object is displaying info of.
		/// This can be set using <see cref="SetCard(Card)"/> method.
		/// </summary>
		public Card Card { get; protected set; }

		/// <summary>
		/// Should be invoked whenever an instance of <see cref="CardSlotUI"/>
		/// is created. Initializes the <see cref="_selectButton"/>'s onClick handler.
		/// </summary>
		public void Init(Action<CardSlotUI> onClicked)
		{
			_selectButton.onClick.AddListener(() => onClicked(this));
		}

		/// <summary>
		/// Sets the reference to <see cref="Card"/> displayed by this object.
		/// </summary>
		public virtual void SetCard(Card card)
		{
			this.Card = card;
			_image.sprite = card.CardData.GetCardInfo().Sprite;
			_cost.text = card.CardData.GetCardInfo().Cost.ToString();
			_levelText.text = "lvl " + card.CardData.level.ToString();
			_selectButton.interactable = true;
		}

		/// <summary>
		/// Changes the color of <see cref="_background"/> image.
		/// </summary>
		public virtual void Select()
		{
			_background.color = _selectedColor;
		}

		/// <summary>
		/// Changes the color of <see cref="_background"/> image.
		/// </summary>
		public virtual void Unselect()
		{
			_background.color = Color.white;
		}
	}
}