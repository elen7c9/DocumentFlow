﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DAL.AbstractRepository;
using DAL.Repositories;
using EntityModels;

namespace BL.PositionsHandlers
{
    public class PositionsHandler
    {
        protected DataRepository<Position> _positionsRepository;

        public PositionsHandler()
        {
            _positionsRepository = new PositionsRepository();
        }

        public List<SelectListItem> PositionsSelectList()
        {
            var positions = _positionsRepository.GetAll(x => true);

            return positions != null
                ? new List<SelectListItem>
                    (positions.Select(x => new SelectListItem {Text = x.Name, Value = x.Id.ToString()}))
                : new List<SelectListItem>();
        }
    }
}