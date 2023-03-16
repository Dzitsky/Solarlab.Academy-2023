﻿namespace Board.Contracts.Account
{
    /// <summary>
    /// Результат входа в аккаунт.
    /// </summary>
    public class LoginResultDto
    {
        /// <summary>
        /// Токен авторизации.
        /// </summary>
        public string JWTToken { get; set; }

        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        public Guid? UserId { get; set; }
    }
}