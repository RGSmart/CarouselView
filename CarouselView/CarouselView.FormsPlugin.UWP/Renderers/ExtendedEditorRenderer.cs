﻿using System;
using CarouselView.FormsPlugin.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Editor), typeof(ExtendedEditorRenderer))]
namespace CarouselView.FormsPlugin.UWP
{
	public class ExtendedEditorRenderer : EditorRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				if (Element.HeightRequest == -1)
					Element.HeightRequest = 32;
			}
		}
	}
}

