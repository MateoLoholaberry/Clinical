﻿namespace CLINICAL.Application.UseCase.Commons.Bases
{
    public class BaseResponse<T>
    {
        public bool IsSuccess { get; set; }

        public T? Data { get; set; }

        public string? Message { get; set; }

        public IEnumerable<BaseErrors>? Errors { get; set; }

    }
}
