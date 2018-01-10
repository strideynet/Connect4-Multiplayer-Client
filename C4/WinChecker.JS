function CheckWin (Board) {
  var Victory = 0
  var Total = 0
  for (BigXLooper = 0; BigXLooper < 4; BigXLooper++) {
    for (BigYLooper = 0; BigYLooper < 3; BigYLooper++) {
      for (SmallXLooper = 0; SmallXLooper < 4; SmallXLooper++) {// Verticals
        Total = 0
        for (SmallYLooper = 0; SmallYLooper < 4; SmallYLooper++) {
          Total += Board[BigXLooper + SmallXLooper][BigYLooper + SmallYLooper]
        }
        If (Total == 36); { Victory = 2 } Else; { If (Total == 4); { Victory = 1 } }
      }
      for (SmallYLooper = 0; SmallYLooper < 4; SmallYLooper++) {// Horizontals
        Total = 0
        for (SmallXLooper = 0; SmallXLooper < 4; SmallXLooper++) {
          Total += Board[BigXLooper + SmallXLooper][BigYLooper + SmallYLooper]
        }
        If (Total == 36); { Victory = 2 } Else; { If (Total == 4); { Victory = 1 } }
      }
      var DiagonalTLBR = Board[BigXLooper][BigYLooper] + Board[BigXLooper + 1][BigYLooper + 1] +// Diagonals
      Board[BigXLooper + 2][BigYLooper + 2] + Board[BigXLooper + 3][BigYLooper + 3] 
      If (DiagonalTLBR == 36); { Victory == 2 } Else; { If (DiagonalTLBR == 4); { Victory = 1 } }
      var DiagonalBLTR = Board[BigXLooper + 3][BigYLooper] + Board[BigXLooper + 2][BigYLooper + 1] +
      Board[BigXLooper + 3][BigYLooper + 2] + Board[BigXLooper][BigYLooper + 3] 
      If (DiagonalBLTR == 36); { Victory == 2 } Else; { If (DiagonalBLTR == 4); { Victory = 1 } }
    }
  }
  return Victory
}
module.exports = CheckWin
// Courtesy of ℵ
