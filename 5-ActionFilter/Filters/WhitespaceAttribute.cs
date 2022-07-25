using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _5_ActionFilter.Filters
{
    public class WhitespaceAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var response = context.HttpContext.Response;
            response.Body = new SpaceCleaner(response.Body);
        }

        public void OnActionExecuting(ActionExecutingContext _)
        {

        }

        private class SpaceCleaner : Stream
        {
            private readonly Stream outputStream;

            public SpaceCleaner(Stream filterStream)
            {
                outputStream = filterStream;
            }

            public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                var html = Encoding.UTF8.GetString(buffer, offset, count);
                var regex = new Regex(@"(?<=\s)\s+(?![^<>]*</pre>)");
                html = regex.Replace(html, string.Empty);
                buffer = Encoding.UTF8.GetBytes(html);
                await outputStream.WriteAsync(buffer, 0, buffer.Length, cancellationToken);
            }

            public override bool CanRead => false;

            public override bool CanSeek => false;

            public override bool CanWrite => true;

            public override long Length => throw new NotImplementedException();

            public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void Flush()
            {
                outputStream.Flush();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotImplementedException();
            }

            public override void SetLength(long value)
            {
                throw new NotImplementedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }
        }
    }
}
