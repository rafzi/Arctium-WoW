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

namespace CharacterServer.Constants.Authentication
{
    public enum AuthResult : byte
    {
        Ok                  = 0xC,
        Failed              = 0xD,
        Reject              = 0xE,
        BadServerProof      = 0xF,
        Unavailable         = 0x10,
        SystemError         = 0x11,
        BillingError        = 0x12,
        BillingExpired      = 0x13,
        VersionMismatch     = 0x14,
        UnknownAccount      = 0x15,
        IncorrectPassword   = 0x16,
        SessionExpired      = 0x17,
        ServerShuttingDown  = 0x18,
        AlreadyLoggingIn    = 0x19,
        LoginServerNotFound = 0x1A,
        WaitQueue           = 0x1B,
        Banned              = 0x1C,
        AlreadyOnline       = 0x1D,
        NoTime              = 0x1E,
        DbBusy              = 0x1F,
        Suspended           = 0x20,
        ParentalControl     = 0x21,
        LockedEnforced      = 0x22
    }
}
