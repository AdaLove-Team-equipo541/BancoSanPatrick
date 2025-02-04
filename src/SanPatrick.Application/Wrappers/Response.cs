﻿namespace SanPatrick.Application.Wrappers
{
    public class Response<T>
    {
        public bool Succesed { get; set; }

        public string? Message { get; set; }

        public List<string>? Errors { get; set; }

        public T? Data { get; set; }

        public Response()
        {

        }
        public Response(T data, string message = null)
        {
            Succesed = true;
            Message = message;
            Data = data;
        }
        public Response(string message)
        {
            Succesed = false;
            Message = message;
        }
    }
}
