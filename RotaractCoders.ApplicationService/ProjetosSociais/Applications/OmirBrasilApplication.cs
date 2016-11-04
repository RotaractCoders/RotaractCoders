using RotaractCoders.Domain.ProjetosSociais.Contracts.Application;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.WebCrowley;
using System;

namespace RotaractCoders.ApplicationService.ProjetosSociais.Applications
{
    public class OmirBrasilApplication : IOmirBrasilApplication
    {
        private IOmirBrasilRepository _omirBrasilRepository;
        private IProjetoRepository _projetoRepository;
        private IDistritoRepository _distritoRepository;
        private IClubeRepository _clubeRepository;

        public OmirBrasilApplication(
            IOmirBrasilRepository omirBrasilRepository, 
            IProjetoRepository projetoRepositoy, 
            IDistritoRepository distritoRepository, 
            IClubeRepository clubeRepository)
        {
            _omirBrasilRepository = omirBrasilRepository;
            _projetoRepository = projetoRepositoy;
            _distritoRepository = distritoRepository;
            _clubeRepository = clubeRepository;
        }

        public bool PersistirProjeto(int codigo)
        {
            try
            {
                var projeto = _omirBrasilRepository.GetByCode(codigo);

                var projetoSalvo = _projetoRepository.Buscar(codigo);

                if (_distritoRepository.Buscar(projeto.Clube.Distrito.Numero) == null)
                {
                    _distritoRepository.Salvar(projeto.Clube.Distrito);
                }

                if (_clubeRepository.Buscar(projeto.Clube.Codigo) == null)
                {
                    _clubeRepository.Salvar(projeto.Clube);
                }

                if (projetoSalvo != null)
                {
                    projeto = projetoSalvo.Atualizar(projeto);
                }

                _projetoRepository.Save(projeto);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _omirBrasilRepository.Dispose();
            _projetoRepository.Dispose();
        }
    }
}