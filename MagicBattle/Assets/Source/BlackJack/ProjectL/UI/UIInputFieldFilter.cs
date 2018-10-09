using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FD6 RID: 4054
	[RequireComponent(typeof(InputField))]
	public class UIInputFieldFilter : MonoBehaviour
	{
		// Token: 0x0601447C RID: 83068 RVA: 0x00528148 File Offset: 0x00526348
		private void Start()
		{
			InputField component = base.GetComponent<InputField>();
			component.onValidateInput = new InputField.OnValidateInput(this.ValidateInput);
		}

		// Token: 0x0601447D RID: 83069 RVA: 0x00528170 File Offset: 0x00526370
		public char ValidateInput(string text, int charIndex, char addedChar)
		{
			if (char.GetUnicodeCategory(addedChar) == UnicodeCategory.Surrogate)
			{
				return '\0';
			}
			return addedChar;
		}
	}
}
