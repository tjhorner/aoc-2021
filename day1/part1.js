const fs = require('fs').promises

async function main() {
  const data = await fs.readFile("./input.txt", "utf8")
  const lines = data.split("\n")

  let numTimes = 0

  for (let i = 1; i < lines.length; i++) {
    const curr = parseInt(lines[i])
    const prev = parseInt(lines[i - 1])
    if (curr > prev) numTimes++
  }

  console.log(numTimes)
}

main()