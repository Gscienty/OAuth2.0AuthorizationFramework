using System;

namespace OAuthService.Framework.Entities
{
    public enum OAuthErrorType : byte
    {
        NoError = 0x01,
        AccessDeniend = 0x02,
        InvalidRequest = 0x04,
        InvalidScope = 0x08,
        ServerError = 0x10,
        TemporarilyUnavailable = 0x20,
        UnAuthorizedClient = 0x40,
        UnsupportedResponseType = 0x80
    }
}