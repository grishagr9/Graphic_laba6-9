using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineTransformations3D
{
    public interface IIdentifiable<T>
    {
        T Identifier { get; }
    }
}
