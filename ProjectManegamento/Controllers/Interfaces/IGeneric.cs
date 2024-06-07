using System;
using System.Collections.Generic;

namespace ProjectManegamento.Controllers.Interfaces
{
    public interface IGeneric<T>
    {
        bool Guardar(T entity);
        List<T> Buscar();
        T Buscar(Func<T, bool> predicate);
        bool Delete(T entity);
    }
}
