using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Entities.Concrete.Color;
namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Entities.Concrete.Color> GetAll()
        {
           return _colorDal.GetAll();
        }

        public Color GetCarsByColorId(int id)
        {
            return _colorDal.Get(p=>p.ColorId==id);
        }

        public void Insert(Color color)
        {
            _colorDal.Add(color);
        }

        public void Update(Entities.Concrete.Color Color)
        {
            _colorDal.Update(Color);
        }
    }
}
