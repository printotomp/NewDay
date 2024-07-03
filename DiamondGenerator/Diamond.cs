using System;
using System.Text;

namespace DiamondGenerator
{
    public class Diamond : IDiamond
    {
        private readonly IInputValidator _inputValidator;

        public Diamond(IInputValidator inputValidator)
        {
            _inputValidator = inputValidator;
        }

        public string Create(char target)
        {
            try
            {
                if (!_inputValidator.IsValidInput(target))
                    return $"Error: Invalid input. Please provide an uppercase letter.";

                int size = target - 'A' + 1;
                var sb = new StringBuilder();

                AppendTopHalf(sb, size);
                AppendBottomHalf(sb, size);

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private void AppendTopHalf(StringBuilder sb, int size)
        {
            for (int i = 0; i < size; i++)
            {
                char currentChar = (char)('A' + i);
                int spacesBefore = size - i - 1;

                sb.Append(' ', spacesBefore);
                sb.Append(currentChar);

                if (currentChar != 'A')
                    sb.Append(' ', 2 * i - 1).Append(currentChar);

                sb.AppendLine();
            }
        }

        private void AppendBottomHalf(StringBuilder sb, int size)
        {
            for (int i = size - 2; i >= 0; i--)
            {
                char currentChar = (char)('A' + i);
                int spacesBefore = size - i - 1;

                sb.Append(' ', spacesBefore);
                sb.Append(currentChar);

                if (currentChar != 'A')
                    sb.Append(' ', 2 * i - 1).Append(currentChar);

                if (i > 0)
                    sb.AppendLine();
            }
        }
    }
}
