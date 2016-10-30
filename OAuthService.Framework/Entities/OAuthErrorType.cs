using System;

namespace OAuthService.Framework.Entities
{
    public enum OAuthErrorType : byte
    {
        NoError = 0x01,
        AccessDeniend = 0x02,
        InvalidRequest = 0x03,
        InvalidScope = 0x04,
        ServerError = 0x05,
        TemporarilyUnavailable = 0x06,
        UnAuthorizedClient = 0x07,
        UnsupportedResponseType = 0x08,
        InvalidClientID = 0x09,
    }
}