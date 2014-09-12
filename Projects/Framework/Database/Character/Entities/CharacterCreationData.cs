﻿/*
 * Copyright (C) 2012-2014 Arctium Emulation <http://arctium.org>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Framework.Attributes;
using Framework.Constants.General;

namespace Framework.Database.Character.Entities
{
    public class CharacterCreationData
    {
        [Field(PrimaryKey = true)]
        public Race Race           { get; set; }
        public Class Class         { get; set; }
        public int Zone            { get; set; }
        public int Map             { get; set; }
        public float X             { get; set; }
        public float Y             { get; set; }
        public float Z             { get; set; }
        public float O             { get; set; }
    }
}