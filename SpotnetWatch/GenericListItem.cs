namespace SpotnetWatch
{
	public class GenericListItem<T>
	{
		private string mText;

		private T mValue;

		public string Text
		{
			get
			{
				return mText;
			}
		}

		public T Value
		{
			get
			{
				return mValue;
			}
		}

		public GenericListItem(string pText, T pValue)
		{
			mText = pText;
			mValue = pValue;
		}

		public override string ToString()
		{
			return mText;
		}
	}
}
