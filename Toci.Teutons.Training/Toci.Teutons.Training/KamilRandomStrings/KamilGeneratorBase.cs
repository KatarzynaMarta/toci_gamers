using System;
using System.Text;

namespace Toci.Teutons.Training.RandomStrings
{
	public abstract class KamilGeneratorBase
	{
		public abstract void GetRandomString(int minLength, int maxLength);

		public abstract void GetRandomPassword(ref int size, ref char[] chars, ref Random rando); // edascx86A

		public abstract void GetStrongRandomPassword(ref int size, ref char[] chars, ref Random random); // F_we23@azWEc^&8

		// ascii

	}
}