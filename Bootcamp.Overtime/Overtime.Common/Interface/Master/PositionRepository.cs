﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;

namespace Overtime.Common.Interface.Master
{
    public class PositionRepository : iPositionRepository
    {
        Position positions = new Position();
        MyContex _context = new MyContex();
        bool status = false;
        public bool delete(int? id)
        {
            var result = 0;
            Position positions = Get(id);
            positions.isDelete = true;
            positions.deleteDate = DateTimeOffset.Now.LocalDateTime;
            result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
            //throw new NotImplementedException();
        }

        public List<Position> Get()
        {
            var getAll = _context.Position.Where(x => x.isDelete == false).ToList();
            return getAll;
            //throw new NotImplementedException();
        }

        public Position Get(int? id)
        {
            var get = _context.Position.Find(id);
            return get;
            //throw new NotImplementedException();
        }

        public bool insert(PositionParam positionParam)
        {
            var result = 0;
            positions.name = positionParam.Name;
            positions.createDate = DateTimeOffset.Now.LocalDateTime;
            positions.isDelete = false;
            _context.Position.Add(positions);
            result = _context.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            return status;
            //throw new NotImplementedException();
        }

        public List<Position> Search(string search, string cmb)
        {
            if(cmb == "Position")
            {
                var searchName = _context.Position.Where(x => x.isDelete != true && x.name.ToString().Contains(search)).ToList();
                return searchName;
            }
            else if(cmb == "Id")
            {
                var searchId = _context.Position.Where(x => x.isDelete != true && x.Id.ToString().Contains(search)).ToList();
                return searchId;
            }
            else
            {
                var refresh = _context.Position.Where(x => x.isDelete != true  ).ToList();
                return refresh;
            }
            //throw new NotImplementedException();
        }

        public bool update(int? id, PositionParam positionParam)
        {
            var result = 0;
            Position positions = Get(id);
            positions.name = positionParam.Name;
            result = _context.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            return status;
            //throw new NotImplementedException();
        }
    }
}
