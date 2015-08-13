window.onload = function() {
	var paper = new Raphael(0, 0, 500, 500);

	paper.path("M 0.00 0.00 L 321.00 0.00 L 321.00 139.00 L 0.00 139.00 L 0.00 0.00 Z").attr({fill: "#fcfdfe"});
	paper.path("M 192.33 10.54 C 222.89 10.26 253.48 10.19 284.03 11.38 C 295.80 11.67 306.58 21.28 307.91 33.04 C 308.80 42.34 309.08 51.71 308.99 61.05 C 308.89 76.04 309.43 91.07 307.90 106.01 C 306.49 117.67 295.84 127.19 284.15 127.57 C 242.44 129.24 200.66 129.22 158.94 127.60 C 146.73 127.38 135.59 117.15 134.67 104.91 C 132.90 81.30 132.90 57.55 134.68 33.93 C 135.62 22.09 146.14 12.05 157.96 11.43 C 169.41 10.87 180.87 10.69 192.33 10.54 Z").attr({fill: "#ec2828"});
	paper.path("M 41.53 29.46 C 45.64 29.39 49.74 29.40 53.85 29.45 C 49.29 43.72 45.06 58.08 40.58 72.38 C 39.50 75.46 39.78 78.76 39.77 81.96 C 39.83 90.42 39.72 98.88 39.83 107.34 C 35.82 107.38 31.81 107.37 27.80 107.35 C 27.81 97.89 27.80 88.43 27.82 78.97 C 27.86 75.14 26.11 71.61 25.14 67.97 C 21.37 55.12 17.12 42.40 13.65 29.46 C 17.64 29.38 21.63 29.38 25.62 29.50 C 27.76 38.67 30.21 47.76 32.36 56.92 C 32.69 58.39 33.28 59.79 33.92 61.15 C 36.61 50.63 39.02 40.03 41.53 29.46 Z").attr({fill: "#4b4b4b"});
	paper.path("M 146.96 28.55 C 159.28 28.50 171.60 28.49 183.92 28.55 C 183.83 32.58 183.84 36.62 183.90 40.65 C 179.75 40.68 175.59 40.68 171.43 40.67 C 171.49 62.90 171.41 85.13 171.47 107.37 C 167.46 107.38 163.44 107.38 159.43 107.37 C 159.49 85.13 159.42 62.90 159.47 40.67 C 155.31 40.68 151.16 40.68 147.01 40.66 C 147.10 36.62 147.11 32.58 146.96 28.55 Z").attr({fill: "#fcfdfe"});
	paper.path("M 224.59 28.52 C 228.21 28.51 231.83 28.51 235.45 28.53 C 235.36 36.88 235.54 45.23 235.34 53.58 C 238.12 50.61 241.78 47.70 246.12 48.30 C 249.84 48.52 253.04 51.29 254.17 54.78 C 255.32 58.40 255.29 62.26 255.29 66.01 C 255.23 76.34 255.34 86.68 255.26 97.01 C 255.35 101.83 252.50 107.56 247.14 107.90 C 242.54 108.72 238.36 106.31 235.36 103.04 C 235.39 104.48 235.43 105.92 235.47 107.37 C 231.84 107.38 228.21 107.38 224.59 107.37 C 224.62 81.09 224.62 54.80 224.59 28.52 Z").attr({fill: "#fcfdfe"});
	paper.path("M 267.14 53.10 C 273.58 44.94 289.15 45.49 293.28 55.69 C 295.87 63.47 294.40 71.84 294.82 79.89 C 288.00 79.95 281.18 79.84 274.37 79.96 C 274.62 85.28 273.77 90.73 274.95 95.97 C 275.77 99.91 282.63 99.84 283.40 95.91 C 284.10 92.61 283.77 89.20 283.82 85.85 C 287.48 85.84 291.14 85.84 294.80 85.84 C 294.94 92.79 295.20 101.28 289.07 105.96 C 282.60 110.34 272.38 110.13 267.22 103.77 C 264.30 100.23 263.38 95.50 263.40 91.01 C 263.41 82.35 263.39 73.69 263.42 65.03 C 263.42 60.80 264.29 56.37 267.14 53.10 Z").attr({fill: "#fcfdfe"});
	paper.path("M 62.31 49.57 C 70.46 46.32 81.60 49.93 83.70 59.11 C 84.85 67.01 83.93 75.09 84.22 83.06 C 83.92 89.17 85.28 95.74 82.42 101.43 C 77.31 111.39 60.60 111.45 55.29 101.64 C 53.59 98.74 53.21 95.30 53.27 92.00 C 53.33 82.02 53.24 72.04 53.30 62.06 C 53.26 56.50 57.09 51.35 62.31 49.57 Z").attr({fill: "#4b4b4b"});
	paper.path("M 183.74 48.92 C 187.29 48.91 190.84 48.91 194.39 48.92 C 194.43 63.62 194.39 78.33 194.40 93.03 C 194.24 94.76 194.98 96.92 197.02 97.02 C 199.79 96.79 201.67 94.50 203.60 92.77 C 203.56 78.15 203.57 63.53 203.59 48.92 C 207.14 48.91 210.70 48.91 214.25 48.92 C 214.28 68.40 214.24 87.89 214.27 107.37 C 210.69 107.38 207.12 107.38 203.55 107.37 C 203.57 105.25 203.60 103.14 203.64 101.03 C 200.99 103.71 198.17 106.47 194.47 107.62 C 191.64 108.62 188.01 108.39 185.94 105.97 C 183.85 103.51 183.78 100.08 183.71 97.02 C 183.75 80.98 183.70 64.95 183.74 48.92 Z").attr({fill: "#fcfdfe"});
	paper.path("M 93.27 49.85 C 96.81 49.84 100.35 49.84 103.89 49.85 C 103.87 63.89 103.91 77.92 103.86 91.96 C 103.94 93.72 103.79 95.66 104.77 97.23 C 107.99 99.28 110.92 95.70 113.16 93.78 C 113.11 79.14 113.16 64.50 113.13 49.85 C 116.67 49.84 120.22 49.84 123.76 49.85 C 123.77 69.02 123.70 88.18 123.80 107.35 C 120.22 107.37 116.65 107.37 113.07 107.34 C 113.12 105.26 113.16 103.18 113.22 101.09 C 110.53 103.80 107.70 106.68 103.92 107.76 C 100.98 108.76 97.14 108.41 95.20 105.72 C 93.43 103.23 93.32 100.01 93.26 97.06 C 93.28 81.32 93.28 65.59 93.27 49.85 Z").attr({fill: "#4b4b4b"});
	paper.path("M 235.49 61.09 C 236.66 57.11 243.91 57.32 244.13 61.96 C 244.59 72.26 244.14 82.60 244.34 92.92 C 244.34 95.03 244.44 98.03 242.00 98.86 C 239.53 99.85 237.28 97.98 235.39 96.65 C 235.53 84.80 235.30 72.94 235.49 61.09 Z").attr({fill: "#ec2828"});
	paper.path("M 66.15 58.98 C 69.01 57.37 73.83 59.19 73.28 62.93 C 73.24 73.63 73.38 84.34 73.21 95.03 C 73.13 99.71 65.18 100.41 64.41 95.75 C 63.96 85.85 64.40 75.92 64.21 66.01 C 64.29 63.61 63.68 60.45 66.15 58.98 Z").attr({fill: "#fcfdfe"});
	paper.path("M 274.93 61.10 C 275.94 57.56 281.95 57.41 283.19 60.84 C 284.18 63.84 283.73 67.08 283.85 70.18 C 280.68 70.19 277.52 70.18 274.36 70.19 C 274.43 67.16 274.06 64.05 274.93 61.10 Z").attr({fill: "#ec2828"});
};