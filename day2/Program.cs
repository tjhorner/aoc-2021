var inFile = Environment.GetCommandLineArgs()[1];
var input = File.ReadAllLines(inFile);

void part1() {
  var xPos = 0;
  var yPos = 0;

  foreach (var line in input) {
    // input appears to only ever have a single digit, so this is fine!
    var num = Int32.Parse(line[line.Length - 1].ToString());
    switch(line[0]) {
      case 'f':
        xPos += num;
        break;
      case 'd':
        yPos += num;
        break;
      case 'u':
        yPos -= num;
        break;
      default:
        break;
    }
  }

  Console.WriteLine($"Part 1:\n{xPos * yPos}");
}

void part2() {
  var xPos = 0;
  var yPos = 0;
  var aim = 0;

  foreach (var line in input) {
    var num = Int32.Parse(line[line.Length - 1].ToString());
    switch(line[0]) {
      case 'f':
        xPos += num;
        yPos += (aim * num);
        break;
      case 'd':
        aim += num;
        break;
      case 'u':
        aim -= num;
        break;
      default:
        break;
    }
  }

  Console.WriteLine($"Part 2:\n{xPos * yPos}");
}

part1();
part2();