﻿//	TextLine.cs
//	Copyright (c). 2018 Daniel Patterson, MCSD (danielanywhere).
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PyDoc
{
	//*-------------------------------------------------------------------------*
	//*	TextLineCollection																											*
	//*-------------------------------------------------------------------------*
	/// <summary>
	/// Collection of TextLineItem Items.
	/// </summary>
	public class TextLineCollection : List<TextLineItem>
	{
		//*************************************************************************
		//*	Private																																*
		//*************************************************************************
		//*************************************************************************
		//*	Protected																															*
		//*************************************************************************
		//*************************************************************************
		//*	Public																																*
		//*************************************************************************
		//*-----------------------------------------------------------------------*
		//*	Add																																		*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Add a new item to the collection by member values.
		/// </summary>
		/// <param name="value">
		/// Line of text to be added.
		/// </param>
		public TextLineItem Add(string value)
		{
			TextLineItem ro = new TextLineItem();

			ro.Value = value;
			this.Add(ro);
			return ro;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//*	AddRange																															*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Add a range of lines to the collection.
		/// </summary>
		/// <param name="text">
		/// Range of lines, each separated by a newline character.
		/// </param>
		public void AddRange(string text)
		{
			string[] sa = new string[0];			//	Working Array.
			string ws = "";										//	Working Local String.

			if(text != null && text.Length > 0)
			{
				ws = text.Replace("\r\n", "\n");
				sa = ws.Split(new char[] { '\n' });
				foreach(string si in sa)
				{
					this.Add(si);
				}
			}
		}
		//*-----------------------------------------------------------------------*
	}
	//*-------------------------------------------------------------------------*

	//*-------------------------------------------------------------------------*
	//*	TextLineItem																														*
	//*-------------------------------------------------------------------------*
	/// <summary>
	/// A single line of text.
	/// </summary>
	public class TextLineItem
	{
		//*************************************************************************
		//*	Private																																*
		//*************************************************************************
		//*************************************************************************
		//*	Protected																															*
		//*************************************************************************
		//*************************************************************************
		//*	Public																																*
		//*************************************************************************
		//*-----------------------------------------------------------------------*
		//*	Value																																	*
		//*-----------------------------------------------------------------------*
		private string mValue = "";
		/// <summary>
		/// Get/Set the Value of this Item.
		/// </summary>
		public string Value
		{
			get { return mValue; }
			set { mValue = value; }
		}
		//*-----------------------------------------------------------------------*
	}
	//*-------------------------------------------------------------------------*
}
