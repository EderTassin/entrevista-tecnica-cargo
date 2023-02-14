
int[] arrayA = {2,3,2,2,2,3,5};
int mitad = (arrayA.Length + 1 )/ 2;
int count;
bool existeValor = false;

for (int i = 0; i < arrayA.Length; i++)
{
	count = 0;

	var countLinq = from item in arrayA where item == arrayA[i] select item;

	count = countLinq.Count();
	 
	if (count >= mitad)
	{
		Console.WriteLine(String.Format("Resultado: {0}", arrayA[i]));
		existeValor = true;
		break;
	}
}

if (!existeValor) Console.WriteLine("-1");





