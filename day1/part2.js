const fs = require('fs').promises

async function main() {
  const data = await fs.readFile("./input.txt", "utf8")
  const lines = data.split("\n")

  const sums = [ ]
  for (let i = 0; i < lines.length; i++) {
    // if ((lines.length - 1) - i < 3) break
    sums.push(parseInt(lines[i]) + parseInt(lines[i + 1]) + parseInt(lines[i + 2]))
  }

  console.log(sums)

  let numTimes = 0

  for (let i = 1; i < sums.length; i++) {
    const curr = sums[i]
    const prev = sums[i - 1]
    if (curr > prev) numTimes++
  }

  console.log(numTimes)
}

main()