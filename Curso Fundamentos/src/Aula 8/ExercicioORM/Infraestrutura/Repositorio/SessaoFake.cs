using System;

namespace MBCorpHealthUnitTest
{
    public class SessaoFake:ISessaoORM<ISessionFake>
    {
        public ISessionFake RetornarSessao()
        {
            throw new NotImplementedException();
        }
    }
}