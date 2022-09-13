using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{

    [Serializable]
    public class MazeUnrenderableException : Exception
    {
        public MazeUnrenderableException() { }
        public MazeUnrenderableException(string message) : base(message) { }
        public MazeUnrenderableException(string message, Exception inner) : base(message, inner) { }
        protected MazeUnrenderableException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
