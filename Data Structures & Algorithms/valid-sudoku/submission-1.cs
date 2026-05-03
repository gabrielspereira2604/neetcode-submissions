public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Verifica linhas
        for (int i = 0; i < 9; i++) {
            if (!IsValidGroup(board[i])) return false;
        }

        // Verifica colunas
        for (int j = 0; j < 9; j++) {
            var col = new char[9];
            for (int i = 0; i < 9; i++) col[i] = board[i][j];
            if (!IsValidGroup(col)) return false;
        }

        // Verifica quadrados 3x3
        for (int square = 0; square < 9; square++) {
            var sq = new char[9];
            int idx = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    sq[idx++] = board[row][col];
                }
            }
            if (!IsValidGroup(sq)) return false;
        }

        return true;
    }

    private bool IsValidGroup(char[] group) {
        var seen = new HashSet<char>();
        foreach (var c in group) {
            if (c == '.') continue;
            if (!seen.Add(c)) return false;
        }
        return true;
    }
}
