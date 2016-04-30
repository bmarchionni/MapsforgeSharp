﻿/*
 * Copyright 2014 Ludwig M Brinckmann
 * Copyright 2016 Dirk Weltz
 *
 * This program is free software: you can redistribute it and/or modify it under the
 * terms of the GNU Lesser General Public License as published by the Free Software
 * Foundation, either version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY
 * WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
 * PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License along with
 * this program. If not, see <http://www.gnu.org/licenses/>.
 */

namespace org.mapsforge.core.graphics
{
	/// <summary>
	/// Utility classes for graphics operations.
	/// </summary>
	public sealed class GraphicUtils
	{
		/// <param name="color">
		///            color value in layout 0xAARRGGBB. </param>
		/// <returns> the alpha value for the color. </returns>
		public static int GetAlpha(int color)
		{
			return (color >> 24) & 0xff;
		}

		private GraphicUtils()
		{
			// noop, just to make tools happy.
		}
	}
}