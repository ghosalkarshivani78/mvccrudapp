using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication4.Dal;

namespace MvcApplication4.Service
{
    public class Taskservice
    {
        Taskdal dal = new Taskdal();

        public int insertperson(Models.Event events)
        {

            return dal.insertperson(events);

        }
        public int update(Models.Event events) 
        {
            return dal.update(events);
        }
        public List<Models.Event> getpersonList()
        {
            return dal.getpersonList();
        }
        public Models.Event getpersonListByid(string id)
        {
            return dal.getpersonListByid(id);
        }
        public int deleteperson(string id) 
        {
            return dal.deleteperson(id);
        }
    }
}