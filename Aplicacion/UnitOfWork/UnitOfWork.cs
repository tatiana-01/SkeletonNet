using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repositories;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
     private readonly SkeletonNetContext context;
     private UsuarioRepository _usuarios;
    private RolRepository _roles;

     public UnitOfWork(SkeletonNetContext _context)
    {
        context = _context;
    }

     public IUsuario Usuarios {
        get{
            if(_usuarios==null){
                _usuarios= new UsuarioRepository(context);
            }
            return _usuarios;
        }
     }
    public IRol Roles {
        get{
            if(_roles==null){
                _roles= new RolRepository(context);
            }
            return _roles;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
         return await context.SaveChangesAsync();
    }
}
