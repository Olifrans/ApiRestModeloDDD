﻿using ApiRestModeloDDD.App.Dtos;
using System.Collections.Generic;

namespace ApiRestModeloDDD.App.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto GetById(int id);
    }
}